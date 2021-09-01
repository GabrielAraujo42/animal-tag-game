using UnityEngine;

public class AnimalHandler : MonoBehaviour
{
    protected IMovement movement;
    protected float forwardInput = 0f;
    protected float horizontalInput = 0f;
    [SerializeField] protected float moveSpeed = 2f;
    [SerializeField] protected float turnSpeed = 1f;
    [SerializeField] protected float jumpForce = 5f;

    void Awake()
    {
        movement = GetComponent<IMovement>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    protected virtual void Move()
    {
        movement.Move(forwardInput * moveSpeed, horizontalInput * turnSpeed);
    }

    protected virtual void Jump()
    {
        movement.Jump(jumpForce);
    }
}