using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseQuaternion : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        if(movement.magnitude > 0)
        {
            // 전방 및 y축을 기준으로 하는 회전을 생성
            // y축 고정.
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);

            // 현재 쿼터니안과 목표 쿼터니언 사이에 구형 보간된 쿼터니언을 반환,
            // 부드러운 회전에 사용.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
