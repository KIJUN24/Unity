using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct ĳ����
{
    public int ����;
    public string �̸�;

}

// �� Ÿ��
public class ValueTypes : MonoBehaviour
{
    private void Start()
    {
        int a = 10;
        int b = a;
        b = 20;

        /*Debug.Log(a);*/



        // �Լ��� ���� ���� ����
        Sum(a, b);

        /*Debug.Log(a);*/



        // ����ü Ÿ�� ����
        ĳ���� �̱���;
        �̱���.���� = 24;
        �̱���.�̸� = "�̱���";

        ĳ���� �̱���2 = �̱���;
        �̱���2.���� = 24;
        �̱���2.�̸� = "�̱���2";

        Debug.Log("�� Ÿ�� �̱���1�� ���� : " + �̱���.���� + "\n");
        Debug.Log("�� Ÿ�� �̱���1�� �̸� : " + �̱���.�̸� + "\n");
        Debug.Log($"�� Ÿ�� �̱���2�� ���� : {�̱���2.����}\n");
        Debug.Log($"�� Ÿ�� �̱���2�� �̸� : {�̱���2.�̸�}\n");

    }

    void Sum(int first, int second)
    {
        // ù ��° �Ű������� ���ƿ� ������ �� ��° �Ű������� ���� ������ ����.
        first += second;
    }
}
