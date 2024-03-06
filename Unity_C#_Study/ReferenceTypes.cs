using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 사용자 정의 데이터 타입

public class 플레이어
{
    public int 나이;
    public string 이름;
}

public class ReferenceTypes : MonoBehaviour
{
    private void Start()
    {
        플레이어 이기준 = new 플레이어();
        이기준.나이 = 20;
        이기준.이름 = "이기준";

        플레이어 이기준2 = 이기준;
        이기준2.나이 = 24;
        이기준2.이름 = "이기준2";

        Debug.Log("---------클래스 타입 예시---------");

        Debug.Log($"참조 타입 이기준1의 나이 : {이기준.나이}");
        Debug.Log($"참조 타입 이기준1의 이름 : {이기준.이름}");
        Debug.Log($"참조 타입 이기준2의 나이 : {이기준2.나이}");
        Debug.Log($"참조 타입 이기준2의 이름 : {이기준2.이름}");

    }
}
