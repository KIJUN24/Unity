using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLerp : MonoBehaviour
{
    Vector3 target = new Vector3(10, 1.5f, 20);

    void Update()
    {
        // 구형 선형 보간 매개변수
        // (매개변수 a와 b, a가 0, b가 1 이라고 가정, 0~1까지의 기준 시간)
        transform.position = Vector3.Slerp(transform.position, target, 0.1f);
    }
}
