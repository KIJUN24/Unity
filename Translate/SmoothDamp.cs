using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDamp : MonoBehaviour
{

    Vector3 target = new Vector3(5, 0, 10);

    void Update()
    {
        // �Ű�����(���� ������, ��ǥ ������, ������ ���� �ӷ�, ����(��, ���� ������ �ǹ�, 0~1 ���̰�)
        /*Vector3 currentVelo = Vector3.up * 30;*/
        Vector3 currentVelo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref currentVelo, 0.1f);
        // ��ǥ ������ �ٴٸ����� ���� �������� ��� �� ���.

    }
}