using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollision : MonoBehaviour
{
    // 물리적인 충돌은 아니지만 충돌했다고 가정해야 할 때 사용.
    // 충돌할 물체 중 적어도 하나는 Collider의 옵션 중 isTrigger를 활성화 해야 한다.

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 충돌 : " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("충돌 중");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("충돌 끝");
    }
}
