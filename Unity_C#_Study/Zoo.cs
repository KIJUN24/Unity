using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    void Start()
    {
        
        // new Ű����� �Բ� Animal Ŭ������ �ν��Ͻ�(�����ض� ��� �ǹ�)
        Animal cat = new Animal();
        cat.name = "����";
        cat.sound = "Miao";
        /*cat.Playsound();*/

        // ���� �� ���� ���� ����� ����
        Animal dog = new Animal();
        dog.name = "����";
        dog.sound = "�۸�";
        /*dog.Playsound();*/

        Animal lion = new Animal();
        lion.name = "����";
        lion.sound = "����";
        /*lion.Playsound();*/

    }
}
