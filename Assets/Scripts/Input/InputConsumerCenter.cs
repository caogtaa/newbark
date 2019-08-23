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

    public void Register(InputConsumer obj, int priority) {
        var consumer = new InputConsumerInner
        {
            priority = priority,
            obj = new WeakReference<InputConsumer>(obj)
        };

        consumers.Add(consumer);
    }

    public void UnRegister(InputConsumer obj) {
        consumers.RemoveWhere(consumer => {
            InputConsumer target;
            bool isAlive = consumer.obj.TryGetTarget(out target);
            return !isAlive || target == obj;
        });
    }

    public InputConsumer GetCurrentConsumer(bool skipOutdated = true) {
        var inner = consumers.Min;
        if (inner == null) {
            return null;
        }

        bool isAlive = inner.obj.TryGetTarget(out InputConsumer target);
        if (isAlive) {
            return target;
        }

        if (skipOutdated) {
            // filter and try again
            UnRegister(null);
            return GetCurrentConsumer(false);
        }

        return null;
    }

    private void FixedUpdate() {
        var target = GetCurrentConsumer();
        if (target) {
            target.OnFixedUpdateHandleInput();
        }
    }
}
