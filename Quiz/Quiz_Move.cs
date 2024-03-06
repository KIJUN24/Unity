using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz_Move : MonoBehaviour
{
    int layerMask = 1 << 3;
    Vector3 target;

    void Update()
    {
        RayMove();



    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter " + collision.gameObject.name);

        // 벽과 충돌했을 때
        if (collision.gameObject.name == "Wall")
        {
            
        }


    }

    private void RayMove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                target = hit.point;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, target, 1f * Time.deltaTime);
    }
}
