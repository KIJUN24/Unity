using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision01 : MonoBehaviour
{
    // 01. �浹ü �浹 : ����
    // �ʿ� ������Ʈ : ������ٵ�, �浹ü(�ݶ��̴�)

    // �浹 �� ���� 1ȸ
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浿ü �浹 : " + collision.gameObject.name);
    }

    // �浹�ϴ� ����
    private void OnCollisionStay(Collision collision)
    {
        
    }

    // �浹�� ������ ��
    private void OnCollisionExit(Collision collision)
    {
        
    }
}
