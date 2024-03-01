using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    Vector3 target = new Vector3(5, 6, 7);

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);
        }
    }
}
