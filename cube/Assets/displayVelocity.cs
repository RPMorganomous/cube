using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayVelocity : MonoBehaviour
{

    public Rigidbody rigidbody;

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        text.text = rigidbody.velocity.ToString();
    }
}
