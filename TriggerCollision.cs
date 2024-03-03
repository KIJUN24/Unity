using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollision : MonoBehaviour
{
    // �������� �浹�� �ƴ����� �浹�ߴٰ� �����ؾ� �� �� ���.
    // �浹�� ��ü �� ��� �ϳ��� Collider�� �ɼ� �� isTrigger�� Ȱ��ȭ �ؾ� �Ѵ�.

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ʈ���� �浹 : " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("�浹 ��");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("�浹 ��");
    }
}
