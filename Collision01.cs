using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision01 : MonoBehaviour
{
    // 01. 충돌체 충돌 : 물리
    // 필요 컴포넌트 : 리지드바디, 충돌체(콜라이더)

    // 충돌 시 최초 1회
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충동체 충돌 : " + collision.gameObject.name);
    }

    // 충돌하는 동안
    private void OnCollisionStay(Collision collision)
    {
        
    }

    // 충돌이 끝났을 때
    private void OnCollisionExit(Collision collision)
    {
        
    }
}
