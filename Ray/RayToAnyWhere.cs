using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayToAnyWhere : MonoBehaviour
{

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DoRayCast();
        }
    }

    void DoRayCast()
    {
        // 레이의 정보를 담을 구초제 변수
        RaycastHit hit;

        // 매개변수 : 어디로부터 방향, 정보 변수, 거리
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            Vector3 target = hit.point;
            Debug.Log("Raycast Point : " + target);

            // 선을 그려 디버깅 (시작점, 목표지점, 색상, 몇 초 동안 수행할지)
            /*Debug.DrawLine(transform.position, target, Color.red, 1.5f);*/

            // 매개변수 (시작점, 방향, 색상, 시간)
            Vector3 dir = target - transform.position;
            Debug.DrawRay(transform.position, dir, Color.red, 1.5f);
        }
    }
}
