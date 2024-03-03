using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 1. 키보드 입력 또는 마우스 입력을 통해 원하는 움직임을 하면서 이동하는 코드를 작성해보세요.

    // 2. 적을 생성하세요

    // 3. 적과 충돌 시 적을 Destory하세요.




    Vector3 target;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                target = hit.point;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, target, 3f * Time.deltaTime);
    }
}
