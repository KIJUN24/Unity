using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseRaycast : MonoBehaviour
{
    // 레이캐스트
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // 광선의 충돌 정보를 담을 변수
            RaycastHit hit;
            
            // 광선을 정의 (메인 카메라로부터 마우스 위치로 광선을 쏜다.)
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // 광선을 사용, (레이, 어느 변수에 저장할 지, 거리)
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.point);
            }
        }
    }
}
