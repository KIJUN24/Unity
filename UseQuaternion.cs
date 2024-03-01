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
            // ���� �� y���� �������� �ϴ� ȸ���� ����
            // y�� ����.
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);

            // ���� ���ʹϾȰ� ��ǥ ���ʹϾ� ���̿� ���� ������ ���ʹϾ��� ��ȯ,
            // �ε巯�� ȸ���� ���.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
