using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Torso : MonoBehaviour
{

    public float mouseSpeed = 100;
    public float maxVerticalRotation = 90;
    private Vector3 torsoRotation;

    private void Start()
    {
        torsoRotation = transform.localRotation.eulerAngles;
    }

    public void Rotation(float xMovement, float yMovement)
    {
        
        //multiply by speed
        xMovement *= mouseSpeed * Time.deltaTime;
        yMovement *= mouseSpeed * -Time.deltaTime;

        //create var with current rotation and add to it
        torsoRotation.x += yMovement;
        torsoRotation.y += xMovement;
		
        //check if exceeds any limits
        torsoRotation.x = Mathf.Clamp(torsoRotation.x, -maxVerticalRotation, maxVerticalRotation);

        Quaternion rotation = Quaternion.Euler(torsoRotation.x, torsoRotation.y, 0);
        transform.rotation = rotation;
    }

}
