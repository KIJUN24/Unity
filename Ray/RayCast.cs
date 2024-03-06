using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 dir;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Vector3 target = hit.point;
                Debug.Log(target);

                float dis = Vector3.Distance(target, ray.origin);
                dir = (target - Camera.main.transform.position).normalized;

                Debug.DrawLine(Camera.main.transform.position, target, Color.blue, 1.5f);
            }
        }
    }
}
