using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsDefault : Legs
{
    public float speed = 2;
    private Rigidbody mechRigidbody;

    
    protected override void InitializeLegs()
    {
        mechRigidbody = transform.parent.GetComponent<Rigidbody>();

    }

    public override void Move(PlayerController.KeyPresses keyPresses)
    {
        // options to prevent slowdown
        // option 1) no friction 
        if (keyPresses.right || keyPresses.left)
        {
            float directionMultiplier = keyPresses.right ? 1 : -1;
            float decreasingAccelerationMultiplier = 1 - Mathf.Abs(keyPresses.wasdInput.x);
            float xAcceleration = decreasingAccelerationMultiplier * directionMultiplier * speed;
            // account for friction
            // check if absolute keypress value is 1
            // if so add just enough velocity to prevent slowdown
            // how much velocity do we have to add to prevent slowdown
            
            mechRigidbody.velocity += Vector3.right * xAcceleration;
        }
        
        if (keyPresses.forward || keyPresses.backward)
        {
            float directionMultiplier = keyPresses.forward ? 1 : -1;
            
            float zAcceleration = (1 - Mathf.Abs(keyPresses.wasdInput.y)) * directionMultiplier * speed;
            mechRigidbody.velocity += Vector3.forward * zAcceleration;
        }

    }

    public override void Jump(bool jumpPressed)
    {
        //print("vel = " + mechRigidbody.velocity.ToString());
    }

}
