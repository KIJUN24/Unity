using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ����� ���� ������ Ÿ��

public class �÷��̾�
{
    public int ����;
    public string �̸�;
}

public class ReferenceTypes : MonoBehaviour
{
    private void Start()
    {
        �÷��̾� �̱��� = new �÷��̾�();
        �̱���.���� = 20;
        �̱���.�̸� = "�̱���";

        �÷��̾� �̱���2 = �̱���;
        �̱���2.���� = 24;
        �̱���2.�̸� = "�̱���2";

        Debug.Log("---------Ŭ���� Ÿ�� ����---------");

        Debug.Log($"���� Ÿ�� �̱���1�� ���� : {�̱���.����}");
        Debug.Log($"���� Ÿ�� �̱���1�� �̸� : {�̱���.�̸�}");
        Debug.Log($"���� Ÿ�� �̱���2�� ���� : {�̱���2.����}");
        Debug.Log($"���� Ÿ�� �̱���2�� �̸� : {�̱���2.�̸�}");

    }
}
