using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLerp : MonoBehaviour
{
    Vector3 target = new Vector3(10, 1.5f, 20);

    void Update()
    {
        // ���� ���� ���� �Ű�����
        // (�Ű����� a�� b, a�� 0, b�� 1 �̶�� ����, 0~1������ ���� �ð�)
        transform.position = Vector3.Slerp(transform.position, target, 0.1f);
    }
}
