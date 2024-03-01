using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 50f;
    

    void Update()
    {
        if(Input.GetKey(KeyCode.X))
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Y))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }
}
