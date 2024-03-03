using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float moveSpeed = 8f;

    private void Update()
    {
        // GetKey : 누르는 동안을 감지, GetKeyDown : 누를 때 한 번만 감지
        if (Input.GetKey(KeyCode.W))
        {
            playerRigidbody.AddForce(0, 0, moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerRigidbody.AddForce(0, 0, -moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(moveSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(-moveSpeed, 0, 0);
        }
    }
}
