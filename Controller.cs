using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 5f;
    CharacterController controller;

    void Start()
    {
        // ���� Component�� �� �־��൵ �ȴ�.
        // transform.AddComponent<CharacterController>();

        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(inputH, 0, inputV).normalized;

        controller.Move(moveDirection * Time.deltaTime * speed);
    }
}
