using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody rigidBody;

    private void Start()
    {
        rigidBody.AddForce(0, 500, 0);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(0, 500, 0);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("Ground"))
        {
            Debug.Log("¶¥¿¡ ´ê¾Ò½À´Ï´Ù.");
        }
    }
}
