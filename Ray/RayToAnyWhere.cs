using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayToAnyWhere : MonoBehaviour
{

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DoRayCast();
        }
    }

    void DoRayCast()
    {
        // ������ ������ ���� ������ ����
        RaycastHit hit;

        // �Ű����� : ���κ��� ����, ���� ����, �Ÿ�
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            Vector3 target = hit.point;
            Debug.Log("Raycast Point : " + target);

            // ���� �׷� ����� (������, ��ǥ����, ����, �� �� ���� ��������)
            /*Debug.DrawLine(transform.position, target, Color.red, 1.5f);*/

            // �Ű����� (������, ����, ����, �ð�)
            Vector3 dir = target - transform.position;
            Debug.DrawRay(transform.position, dir, Color.red, 1.5f);
        }
    }
}
