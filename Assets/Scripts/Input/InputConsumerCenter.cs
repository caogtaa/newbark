using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class InputConsumerCenter : Singleton<InputConsumerCenter>
{
    // prevent local allocation
    protected InputConsumerCenter() { }

    private class InputConsumerInner
    {
        public int priority;        // smaller prior
        public WeakReference<InputConsumer> obj;    // todo: maybe weakref is an overkill, will InputConsumer release in runtime?
        public bool shouldRemove = false;
    };

    private class ByPriority : IComparer<InputConsumerInner>
    {
        public int Compare(InputConsumerInner x, InputConsumerInner y) {
            if (x.priority != y.priority)
                return x.priority.CompareTo(y.priority);

            // prevent key duplication, or if they still equals, unique invoker's priority
            return x.GetHashCode().CompareTo(y.GetHashCode());
        }
    }

    private SortedSet<InputConsumerInner> consumers = new SortedSet<InputConsumerInner>(new ByPriority());
    private List<InputConsumerInner> pendingConsumers = new List<InputConsumerInner>();

    // for caching current consumer
    private InputConsumer currentConsumer = null;
    private bool hasCurrentConsumerCache = false;

    public void Register(InputConsumer obj, int priority) {
        var consumer = new InputConsumerInner
        {
            priority = priority,
            obj = new WeakReference<InputConsumer>(obj)
        };

        // all Register will not affect current frame, and will be inserted in LateUpdate()
        pendingConsumers.Add(consumer);
    }

    public void UnRegister(InputConsumer obj) {
        Predicate<InputConsumerInner> shouldRemovePred = consumer => {
            InputConsumer target;
            bool isAlive = consumer.obj.TryGetTarget(out target);
            return !isAlive || target == obj;
        };

        // pending objects can be removed directly
        pendingConsumers.RemoveAll(shouldRemovePred);

        // all UnRegister will not affect current frame, and will be removed in LateUpdate()
        var iter = consumers.GetEnumerator();
        while (iter.MoveNext()) {
            if (shouldRemovePred(iter.Current)) {
                iter.Current.shouldRemove = true;
            }
        }
    }

    public InputConsumer GetCurrentConsumer(bool skipOutdated = true) {
        // should snapshot this consumer, because force GC may happen in the middle
        if (hasCurrentConsumerCache)
            return currentConsumer;

        var iter = consumers.GetEnumerator();
        while (iter.MoveNext()) {
            bool isAlive = iter.Current.obj.TryGetTarget(out currentConsumer);
            if (isAlive) {
                hasCurrentConsumerCache = true;
                return currentConsumer;
            }

            iter.Current.shouldRemove = true;
        }

        hasCurrentConsumerCache = true;
        currentConsumer = null;
        return null;
    }

    private void FixedUpdate() {
        var target = GetCurrentConsumer();
        if (target) {
            target.OnFixedUpdateHandleInput();
        }
    }

    private void LateUpdate() {
        // remove
        consumers.RemoveWhere(consumer => {
            return consumer.shouldRemove == true;
        });

        // add pending consumers
        if (pendingConsumers.Count > 0) {
            consumers.UnionWith(pendingConsumers);
            pendingConsumers.Clear();
        }

        hasCurrentConsumerCache = false;
        currentConsumer = null;
    }
}
