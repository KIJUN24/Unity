using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float moveSpeed = 8f;

    private void Update()
    {
        // GetKey : ������ ������ ����, GetKeyDown : ���� �� �� ���� ����
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
