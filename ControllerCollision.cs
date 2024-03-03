using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌체 충돌 : " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 충돌 : " + other.gameObject.name);
    }
}
