using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 0, 0);
    Transform target;

    public float rotationSpeed = 8f;
    public float transSpeed = 2f;

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        transform.position = target.position + offset;
        /*transform.position = Vector3.Lerp(transform.position, target.position + offset, 0.03f);*/

        Vector3 movement = new Vector3(inputH, 0f, inputV).normalized;

        if (movement.magnitude > 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
