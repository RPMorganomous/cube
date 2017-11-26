using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Legs : MonoBehaviour
{
    protected void Start()
    {
        InitializeLegs();
    }

    protected abstract void InitializeLegs();
    
    public abstract void Move(PlayerController.KeyPresses keyPresses);
    public abstract void Jump(bool jumpPressed);
}
