using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseLook : MonoBehaviour
{
    public float sensitivity = 2.0f; // 마우스 감도
    public Transform player; // 플레이어의 Transform
    private float verticalRotation = 0f; // 세로 회전 각도

    void Update()
    {
        // 마우스 입력을 받아서 카메라 회전
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // 수평 회전: 플레이어의 y축을 기준으로 마우스 X 축으로 회전
        player.Rotate(Vector3.up * mouseX);

        // 수직 회전: 카메라를 상하로 움직여야 하므로 카메라 자체를 회전
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // 상하 회전 각도 제한
        transform.localRotation = Quaternion.Euler(verticalRotation, player.eulerAngles.y, 0f);
    }
}
