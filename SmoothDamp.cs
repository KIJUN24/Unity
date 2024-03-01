using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDamp : MonoBehaviour
{

    Vector3 target = new Vector3(5, 0, 10);

    void Update()
    {
        // 매개변수(현재 포지션, 목표 포지션, 참조할 현재 속력, 댐프(즉, 제동 정도를 의미, 0~1 사이값)
        /*Vector3 currentVelo = Vector3.up * 30;*/
        Vector3 currentVelo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref currentVelo, 0.1f);
        // 목표 지점에 다다를수록 점차 느려지게 운동할 때 사용.

    }
}