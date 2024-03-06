using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseLook : MonoBehaviour
{
    public float sensitivity = 2.0f; // ���콺 ����
    public Transform player; // �÷��̾��� Transform
    private float verticalRotation = 0f; // ���� ȸ�� ����

    void Update()
    {
        // ���콺 �Է��� �޾Ƽ� ī�޶� ȸ��
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // ���� ȸ��: �÷��̾��� y���� �������� ���콺 X ������ ȸ��
        player.Rotate(Vector3.up * mouseX);

        // ���� ȸ��: ī�޶� ���Ϸ� �������� �ϹǷ� ī�޶� ��ü�� ȸ��
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // ���� ȸ�� ���� ����
        transform.localRotation = Quaternion.Euler(verticalRotation, player.eulerAngles.y, 0f);
    }
}
