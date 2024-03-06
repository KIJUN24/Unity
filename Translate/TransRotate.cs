using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransRotate : MonoBehaviour
{
    public float rotationSpeed = 8f;
    public float transSpeed = 2f;

    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        Vector3 moveDistance = new Vector3(inputH, 0, inputV).normalized;

        transform.position += moveDistance * Time.deltaTime * transSpeed;

        Vector3 movement = new Vector3(inputH, 0f, inputV).normalized;

        if (movement.magnitude > 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
