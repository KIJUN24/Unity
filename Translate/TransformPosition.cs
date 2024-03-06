using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        Vector3 moveDistance = new Vector3(inputH, 0, inputV).normalized;

        transform.position += moveDistance * Time.deltaTime * speed;
    }
}
