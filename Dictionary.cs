using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    // Ű�� ���� �� ������ �ϴ� �׸� ����
    // Ű, ��
    // Ű�� ������ �� ������ ���� ������ �� �ִ�.
    Dictionary<string, int> students = new Dictionary<string, int>();
    Dictionary<int, string> itemDB = new Dictionary<int, string>();

    void Start()
    {
        students.Add("�̱���", 1);
        students.Add("ȫ�浿", 2);
        students.Add("�̼���", 3);

        int number;
        students.TryGetValue("�̱���", out number);
        Debug.Log("�̱����� ��ȣ��? " + number);

        // �ش� Ű�� �����ϴ���
        if(students.ContainsKey("ȫ�浿"))
        {
            Debug.Log("�л� ��ܿ� ȫ�浿�� �����Ѵ�.");
        }

        // �ش� ���� �����ϴ��� �˻�, ������ ���� ������ ��찡 ���� �� �ձ� ������ ��ȿ��
        if(students.ContainsValue(3))
        {
            Debug.Log("�����Ѵ�.");
        }

        // Ű�� �̿��Ͽ� ���� ����� �� �̿� ���� ����� �� �ִ�.
        int numberOfName = students["�̼���"];
        Debug.Log("�̼����� ��ȣ�� : " + numberOfName);




        // db����
        itemDB.Add(01, "sword");
        itemDB.Add(03, "amor");
        itemDB.Add(07, "potion");
        itemDB.Add(101, "gold");

        // ���ϴ� Ű�� ���� ����ϰ� ���� ��
        Debug.Log("101�� ������ : " + itemDB[101]);

        // ���� : itemDB ��ųʸ� �ȿ� ��� Ű�� ���� ����ϰ� ���� ��
        foreach (var kvp in itemDB)
        {
            Debug.Log("Key : " + kvp.Key + " value : " + kvp.Value);
        }
    }



    
}
