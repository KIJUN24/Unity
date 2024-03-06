using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    // 키와 값을 한 쌍으로 하는 그릇 구조
    // 키, 값
    // 키는 동일할 수 없지만 값은 동일할 수 있다.
    Dictionary<string, int> students = new Dictionary<string, int>();
    Dictionary<int, string> itemDB = new Dictionary<int, string>();

    void Start()
    {
        students.Add("이기준", 1);
        students.Add("홍길동", 2);
        students.Add("이순신", 3);

        int number;
        students.TryGetValue("이기준", out number);
        Debug.Log("이기준의 번호는? " + number);

        // 해당 키가 존재하는지
        if(students.ContainsKey("홍길동"))
        {
            Debug.Log("학생 명단에 홍길동이 존재한다.");
        }

        // 해당 값이 존재하는지 검색, 하지만 값이 동일한 경우가 있을 수 잇기 때문에 비효율
        if(students.ContainsValue(3))
        {
            Debug.Log("존재한다.");
        }

        // 키를 이용하여 값을 출력할 때 이와 같이 사용할 수 있다.
        int numberOfName = students["이순신"];
        Debug.Log("이순신의 번호는 : " + numberOfName);




        // db설계
        itemDB.Add(01, "sword");
        itemDB.Add(03, "amor");
        itemDB.Add(07, "potion");
        itemDB.Add(101, "gold");

        // 원하는 키의 값만 출력하고 싶을 때
        Debug.Log("101인 아이템 : " + itemDB[101]);

        // 문제 : itemDB 딕셔너리 안에 모든 키와 값을 출력하고 싶을 때
        foreach (var kvp in itemDB)
        {
            Debug.Log("Key : " + kvp.Key + " value : " + kvp.Value);
        }
    }



    
}
