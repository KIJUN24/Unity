using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    // �̸� ����
    public string name;
    // ���� �Ҹ�
    public string sound;
    // ���� �Ҹ� ����ϴ� �޼���(�Լ�)
    public void Playsound()
    {
        Debug.Log(name + " : " + sound);
    }
}
