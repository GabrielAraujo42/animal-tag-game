using UnityEngine;

public class FoxMovement : MonoBehaviour, IMovement
{
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(float forwardMove, float horizontalTurn)
    {
        if(horizontalTurn != 0)
        {
            transform.Rotate(0f, horizontalTurn, 0f);
        }
        if(forwardMove != 0)
        {
            Vector3 dir = transform.forward * forwardMove;
            rb.velocity = new Vector3(dir.x, rb.velocity.y, dir.z);
        }
    }

    public void Jump(float jumpForce)
    {
        // if on ground
        rb.velocity += new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }
}