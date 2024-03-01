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
        // 직접 Component를 안 넣어줘도 된다.
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
