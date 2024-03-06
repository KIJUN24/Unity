using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRaycast : MonoBehaviour
{
    Vector3 target;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                target = hit.point;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, target, 1f * Time.deltaTime);
    }
}
