using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class convey : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody>().velocity = Vector3.forward * 3;
	}
}
