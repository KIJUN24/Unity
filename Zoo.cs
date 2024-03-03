using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    void Start()
    {
        
        // new 키워드와 함꼐 Animal 클래스를 인스턴싱(생성해라 라는 의미)
        Animal cat = new Animal();
        cat.name = "냥이";
        cat.sound = "Miao";
        /*cat.Playsound();*/

        // 동물 두 종류 정도 만들어 보기
        Animal dog = new Animal();
        dog.name = "강쥐";
        dog.sound = "멍멍";
        /*dog.Playsound();*/

        Animal lion = new Animal();
        lion.name = "사자";
        lion.sound = "어흥";
        /*lion.Playsound();*/

    }
}
