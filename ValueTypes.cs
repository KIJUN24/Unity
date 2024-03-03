using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct 캐릭터
{
    public int 나이;
    public string 이름;

}

// 값 타입
public class ValueTypes : MonoBehaviour
{
    private void Start()
    {
        int a = 10;
        int b = a;
        b = 20;

        /*Debug.Log(a);*/



        // 함수의 지역 변수 예시
        Sum(a, b);

        /*Debug.Log(a);*/



        // 구조체 타입 예시
        캐릭터 이기준;
        이기준.나이 = 24;
        이기준.이름 = "이기준";

        캐릭터 이기준2 = 이기준;
        이기준2.나이 = 24;
        이기준2.이름 = "이기준2";

        Debug.Log("값 타입 이기준1의 나이 : " + 이기준.나이 + "\n");
        Debug.Log("값 타입 이기준1의 이름 : " + 이기준.이름 + "\n");
        Debug.Log($"값 타입 이기준2의 나이 : {이기준2.나이}\n");
        Debug.Log($"값 타입 이기준2의 이름 : {이기준2.이름}\n");

    }

    void Sum(int first, int second)
    {
        // 첫 번째 매개변수로 돌아온 정수에 두 번째 매개변수로 들어온 정수를 더함.
        first += second;
    }
}
