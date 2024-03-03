using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    // 이름 변수
    public string name;
    // 울음 소리
    public string sound;
    // 울음 소리 재생하는 메서드(함수)
    public void Playsound()
    {
        Debug.Log(name + " : " + sound);
    }
}
