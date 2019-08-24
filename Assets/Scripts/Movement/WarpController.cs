using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Serialization;
using DG.Tweening;

/**
 * Warp Controller. Attach this controller to the object that moves an warps, usually the player.
 */
public class WarpController : MonoBehaviour
{
    public MovementController movementController;

    public GameObject fadeMask;
    private bool _isWarping = false;

    private void WarpToDropStart(WarpZone destination)
    {
        Vector2 coords = destination.dropZone.transform.position.AsVector2() + destination.dropZoneOffset;
        movementController.ClampPositionTo(new Vector3(coords.x, coords.y, 0));
    }

    private void MoveToDropEnd(WarpZone destination)
    {
        if (destination.postDropMove.steps == 0)
        {
            if (destination.postDropMove.direction != DIRECTION_BUTTON.NONE)
            {
                movementController.Move2(destination.postDropMove.direction);
                // movementController.TriggerButtons(destination.postDropMove.direction, ACTION_BUTTON.NONE);
            }

            return;
        }

        movementController.Move2(destination.postDropMove.direction, destination.postDropMove.steps);
        /*if (!movementController.Move(destination.postDropMove.direction, destination.postDropMove.steps))
        {
            Debug.LogWarning("!!! WARPER CANNOT BE MOVED");
        }*/
    }

    private bool IsWarpZone(Collider2D other)
    {
        return other.gameObject.HasComponent<WarpZone>();
    }

    private WarpZone GetWarpZone(Collider2D other)
    {
        return other.gameObject.GetComponent<WarpZone>();
    }

    // todo: use generic function
    private WarpController weakToStrong(WeakReference<WarpController> weakRef) {
        bool isAlive = weakRef.TryGetTarget(out WarpController target);
        return target;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!IsWarpZone(other))
            return;

        if (_isWarping)
            return;

        _isWarping = true;

        // start warping
        var image = fadeMask.GetComponent<Image>();

        Color color = image.color;
        color.a = 0;
        image.color = color;
        image.enabled = true;

        var weakThis = new WeakReference<WarpController>(this);
        var sequence = DOTween.Sequence();
        sequence.Append(image.DOFade(1, 0.6f));
        sequence.AppendCallback(() => {
            // do move player
            var strongThis = weakToStrong(weakThis);
            if (!strongThis)
                return;

            WarpToDropStart(GetWarpZone(other));
        });
        sequence.Append(image.DOFade(0, 0.4f));
        sequence.AppendCallback(() => {
            // warping terminated
            var strongThis = weakToStrong(weakThis);
            if (!strongThis)
                return;

            MoveToDropEnd(GetWarpZone(other));
            image.enabled = false;
            strongThis._isWarping = false;
        });
    }

    void OnTriggerStay2D(Collider2D other)
    {
    }

    void OnTriggerExit2D(Collider2D other)
    {
    }
}