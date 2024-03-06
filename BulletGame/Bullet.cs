using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // 강체의 속력을 트랜스폼의 앞쪽방향 * speed로 대입.
        rb.velocity = transform.forward * speed;

        // 오브젝트 파괴 함수 매개변수 2가지 (파괴시킬 오브젝트, 시간 경과(몇 초 뒤))
        Destroy(gameObject, 3f);
    }

    // 트리거 충돌 시작될 때 매개변수 (클라이더)
    private void OnTriggerEnter(Collider other)
    {
        // 클라이더의 태그가 Player와 같다면,
        if(other.tag == "Player")
        {

        }
        // 위 코드와 동일
        // CompareTag를 쓰기 권장.
        if (other.CompareTag("Player"))
        {
            Debug.Log("충돌");

            // 플레이어 선언, 트리거 충돌된 other에서 Player 스크립트 가져옴
            Player_1 player = other.GetComponent<Player_1>();

            // 플레이어 가져오는 데 성공했다면,
            if(player != null)  // 혹시 모를 에러를 예방하기 위해
            {
                // Die() 함수 실행
                player.Die();
                Debug.Log("Player Die");
            }

        }
    }


    /*
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("충돌 중");

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("충돌 끝");

    }*/
}
