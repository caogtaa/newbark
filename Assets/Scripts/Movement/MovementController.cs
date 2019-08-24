using UnityEngine;

public class MovementController : InputConsumer
{
    [Header("Movement")] public Animator animator;
    public int speed = 6;
    public int inputDelay = 8;
    public int tilesToMove = 1;
    public float clampAt = 0.5f;
    public float raycastDistance = 1f;

    [Header("Debug")] private int currentTilesToMove = 1;
    public GameObject lastCollidedObject;
    public DIRECTION_BUTTON lastCollisionDir = DIRECTION_BUTTON.NONE;

    public Vector3 destPosition;
    public DIRECTION_BUTTON lastMoveDir = DIRECTION_BUTTON.DOWN;    // hardcode init state
    public bool mIsMoving = false;
    private int changeDirCoolDown = 0;

    private GameObject player;

    void Start()
    {
        if (!animator)
        {
            animator = GetComponentInChildren<Animator>();
        }

        currentTilesToMove = tilesToMove;

        InputConsumerCenter.Instance.Register(this, 100);
    }

    void FixedUpdate() {
        if (InputConsumerCenter.Instance.GetCurrentConsumer() != this) {
            // need auto move in some case
            Move2();
            return;
        }

        // handle other logic in OnFixedUpdateHandleInput
    }

    public override void OnFixedUpdateHandleInput() {
        DIRECTION_BUTTON dir = InputController.GetPressedDirectionButton();
        ACTION_BUTTON action = InputController.GetPressedActionButton();
        Move2(dir);

        if (action != ACTION_BUTTON.NONE) {
            TryInteract(lastMoveDir, action);
        }
    }

    public DIRECTION_BUTTON GetFaceDirection()
    {
        if (animator.GetFloat("LastMoveX") > 0)
        {
            return DIRECTION_BUTTON.RIGHT;
        }

        if (animator.GetFloat("LastMoveX") < 0)
        {
            return DIRECTION_BUTTON.LEFT;
        }

        if (animator.GetFloat("LastMoveY") > 0)
        {
            return DIRECTION_BUTTON.UP;
        }

        if (animator.GetFloat("LastMoveY") < 0)
        {
            return DIRECTION_BUTTON.DOWN;
        }

        return DIRECTION_BUTTON.DOWN;
    }

    public Vector2 GetFaceDirectionVector()
    {
        switch (GetFaceDirection())
        {
            case DIRECTION_BUTTON.UP:
                return Vector2.up;
            case DIRECTION_BUTTON.DOWN:
                return Vector2.down;
            case DIRECTION_BUTTON.LEFT:
                return Vector2.left;
            case DIRECTION_BUTTON.RIGHT:
                return Vector2.right;
            default:
                return Vector2.zero;
        }
    }

    public Vector3 GetMovementVector(DIRECTION_BUTTON dir, int tiles = 1)
    {
        switch (dir)
        {
            case DIRECTION_BUTTON.UP:
                return Vector3.up * tiles;
            case DIRECTION_BUTTON.DOWN:
                return Vector3.down * tiles;
            case DIRECTION_BUTTON.LEFT:
                return Vector3.left * tiles;
            case DIRECTION_BUTTON.RIGHT:
                return Vector3.right * tiles;
            default:
                return Vector3.zero;
        }
    }

    private RaycastHit2D CheckRaycast(Vector2 direction)
    {
        Vector2 startingPosition = (Vector2) transform.position;

        return Physics2D.Raycast(startingPosition, direction, raycastDistance);
    }

    private RaycastHit2D CheckFutureRaycast(Vector2 direction)
    {
        Vector2 startingPosition = (Vector2) transform.position;

        return Physics2D.Raycast(startingPosition, direction, raycastDistance * 2);
    }

    public void Move2(DIRECTION_BUTTON dir = DIRECTION_BUTTON.NONE, int tiles = 1) {
        if (IsMoving2()) {
            // continue moving to destination, can not change direction in the middle
            float delta = Time.fixedDeltaTime * speed;
            transform.position = Vector3.MoveTowards(transform.position, destPosition, delta);
            if (transform.position == destPosition) {
                StopMoving2();
            } else if (Vector3.Distance(transform.position, destPosition) <= delta && dir == lastMoveDir) {
                // destination is close enough, update destination
                // in order to make it more smooth for long time key press
                destPosition += GetMovementVector(dir, tiles);
            }

            return;
        }

        if (dir != DIRECTION_BUTTON.NONE) {
            if (--changeDirCoolDown > 0)
                return;
            changeDirCoolDown = 0;

            var movementVector = GetMovementVector(dir, tiles);
            if (dir != lastMoveDir) {
                // face to that dir first
                lastMoveDir = dir;
                FaceTo(movementVector);

                // skip 8 frames before player can move
                changeDirCoolDown = inputDelay;
            } else {
                destPosition = transform.position + movementVector;
                StartMovingAnimation(movementVector);
            }
        }
    }

    private bool TryInteract(DIRECTION_BUTTON dir, ACTION_BUTTON action) {
        if (action == ACTION_BUTTON.NONE)
            return false;

        Vector3 dirVector = GetMovementVector(dir); // todo: change function name
        if (dirVector == Vector3.zero)
            return false;

        RaycastHit2D hit = CheckRaycast(dirVector);
        // Debug.DrawRay(transform.position, dirVector, Color.green);
        if (hit.collider) {
            // Debug.DrawRay(transform.position, dirVector, Color.red);
            // Debug.DrawRay(transform.position, hit.point, Color.blue);

            if (hit.collider.gameObject.HasComponent<Interactable>()) {
                // Debug.Log("[raycast hit] @interactable " + hit.collider.gameObject.name);
                hit.collider.gameObject.GetComponent<Interactable>().Interact(action);
                return true;
            }
        }

        return false;
    }

    private void StartMovingAnimation(Vector3 movement) {
        mIsMoving = true;
        animator.SetFloat("MoveX", movement.x);
        animator.SetFloat("MoveY", movement.y);
        animator.SetFloat("LastMoveX", movement.x);
        animator.SetFloat("LastMoveY", movement.y);
        animator.SetBool("Moving", mIsMoving);
    }

    public void FaceToDir(DIRECTION_BUTTON dir) {
        if (dir == DIRECTION_BUTTON.NONE)
            dir = DIRECTION_BUTTON.DOWN;

        if (lastMoveDir == dir)
            return;

        var movementVector = GetMovementVector(dir);
        lastMoveDir = dir;
        FaceTo(movementVector);
    }

    private void FaceTo(Vector3 movement) {
        // mIsMoving = false;
        animator.SetFloat("MoveX", movement.x);
        animator.SetFloat("MoveY", movement.y);
        animator.SetFloat("LastMoveX", movement.x);
        animator.SetFloat("LastMoveY", movement.y);
        animator.SetBool("Moving", false);
    }

    private void StopMoving2() {
        mIsMoving = false;
        animator.SetBool("Moving", mIsMoving);
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        // Debug.Log("Collision ENTER between " + this.name + " and " + col.gameObject.name);

        lastCollidedObject = col.gameObject;
        // lastCollisionDir = movement.LastDirection;
        lastCollisionDir = lastMoveDir;

        StopMoving2();
        ClampCurrentPosition();

        PlayCollisionSound(lastCollidedObject);
    }

    void OnCollisionStay2D(Collision2D col)
    {
        // Debug.Log("Collision STAY between " + this.name + " and " + col.gameObject.name);

//         lastCollidedObject = col.gameObject;
//         lastCollisionDir = movement.LastDirection;
// 
//         if (movement.IsMoving)
//         {
//             PlayCollisionSound(lastCollidedObject);
//         }
// 
//         StopMoving();
    }

    bool HasCollisionSound(GameObject gobj)
    {
        return gobj.HasComponent<AudioSource>();
    }

    AudioSource GetCollisionSound(GameObject gobj)
    {
        if (!HasCollisionSound(gobj))
        {
            return null;
        }

        gobj.TryGetComponent(typeof(AudioSource), out Component aud);
        return (AudioSource) aud;
    }

    void PlayCollisionSound(GameObject gobj)
    {
        AudioSource audioSource = GetCollisionSound(gobj);

        if (audioSource is AudioSource && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void ClampCurrentPosition()
    {
        ClampPositionTo(transform.position);
    }

    public bool IsMoving2() {
        return mIsMoving;
    }

    public void ClampPositionTo(Vector3 position)
    {
        transform.position = ClampPosition(position);

        // override in case collision physics caused object rotation
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }


    public Vector3 ClampPosition(Vector3 position) {
        Vector3 fixedPos = new Vector3(ClampPositionAxis(position.x), ClampPositionAxis(position.y), 0);
        return fixedPos;

    }

    private float ClampPositionAxis(float val) {
        float mod = val % 1f;

        if (System.Math.Abs(mod - clampAt) < double.Epsilon) // more precise than: if (mod == fraction)
        {
            return val;
        }

        if (val < 0f) {
            return (val - mod) - clampAt;
        }

        return (val - mod) + clampAt;
    }
}