using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translatemove : MonoBehaviour
{

    public float speed = 1f;
    
    Vector3 originPosition = Vector3.zero;
    Vector3 currentPosition = Vector3.zero;

    // 얼만큼의 시간동안 이동하였는지
    float moveTime;

    void Start()
    {
        originPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log(Time.deltaTime);*/
        float inputH = Input.GetAxis("Horizontal");     // 좌우 화살표
        float inputV = Input.GetAxis("Vertical");       


        // 백터의 정규화 (크기가 1인 벡터로 만들어 줌.
        // 즉, 크기는 1로 동일하고 방향값만 가지게 된다.
        // 대각선으로 갈 때 속도가 달라지는 것을 방지할 수 있음.
        Vector3 movement = new Vector3(inputH, 0f, inputV).normalized;


        // 키가 눌렸을 때
        if(movement.magnitude > 0)
        {
            // Translate() 함수가 어떤 매개변수를 갖는가?
            // 첫 번째 매개변수 : 어디로 변화시킬지
            // 두 번째 매개변수 : 공간의 기준
            
            transform.Translate(movement * Time.deltaTime * speed, Space.World);
            // Time.deltTime을 곱해주는 이유
            // : movement * Time.deltatime을 해주면 사향이 좋은, 안 좋은 pc가 모두 (FPS)동일한 조건이 된다.

            // 키가 눌린 동안의 시간
            moveTime += Time.deltaTime;
            if(moveTime >= 1f)
            {
                currentPosition = transform.position;
                float distance = Vector3.Distance(originPosition, currentPosition);
                float speed = distance / moveTime;
                Debug.Log($"초당 속력 : {speed}");

                originPosition = currentPosition;
                moveTime = 0f;
            }
        }

        // 속력 : 거리 / 시간
        // 거리 : Vector3.Distance(A,B) : A와 B사이의 거리(float)

    }
}
