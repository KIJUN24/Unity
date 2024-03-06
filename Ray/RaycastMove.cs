using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastMove : MonoBehaviour
{
    Vector3 target = Vector3.zero;
    int layerMask = 1 << 3;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // 
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Debug.Log(hit.point);
                target = hit.point;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, target, 3f * Time.deltaTime);
    }
}
