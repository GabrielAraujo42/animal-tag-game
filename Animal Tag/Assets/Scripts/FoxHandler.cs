using UnityEngine;

public class FoxHandler : AnimalHandler
{
    

    protected override void Move()
    {
        forwardInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");
        base.Move();
    }

    protected override void Jump()
    {
        // Fox behaviours
        if (Input.GetKeyDown(KeyCode.Space))
        {
            base.Jump();
        }
    }
}