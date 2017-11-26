using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Legs legs;
	private KeyPresses keyPresses;
	private bool jumpPressed;
	private Torso torso;

	
	void Start ()
	{
		legs = GetComponentInChildren(typeof(Legs)) as Legs;
		torso = GetComponentInChildren(typeof(Torso)) as Torso;
	}
	
	void Update ()
	{
		UpdateInputVariables();
		DelegateMouseRotation();
	}
	
	void UpdateInputVariables()
	{
		keyPresses.wasdInput.x = Input.GetAxis("Horizontal");
		keyPresses.wasdInput.y = Input.GetAxis("Vertical");
		keyPresses.forward = Input.GetKey(KeyCode.W);
		keyPresses.backward = Input.GetKey(KeyCode.S);
		keyPresses.left = Input.GetKey(KeyCode.A);
		keyPresses.right = Input.GetKey(KeyCode.D);
		
		jumpPressed = Input.GetKey(KeyCode.Space);
	}

	public struct KeyPresses
	{
		public bool forward;
		public bool backward;
		public bool right;
		public bool left;

		public Vector2 wasdInput;
	}
	
	void DelegateMouseRotation()
	{
		//find mouse movement
		float xMovement = Input.GetAxis("Mouse X");
		float yMovement = Input.GetAxis("Mouse Y");
		torso.Rotation(xMovement, yMovement);
	}
	
	void DelegateMovement()
	{
		legs.Move(keyPresses);
		legs.Jump(jumpPressed);
	}
	
	void FixedUpdate()
	{
		DelegateMovement();
	}
}
