using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // List 초기화의 원형
    // 실행 중 가변적으로(동적) 크기가 변할 수 있다.
    public List<GameObject> objList = new List<GameObject>();

    void Start()
    {
        // 리스트 비우기
        objList.Clear();

        // 리스트 추가
        objList.Add(GameObject.Find("Cube"));
        objList.Add(GameObject.Find("Plane"));
        objList.Add(GameObject.Find("Sphere"));
        objList.Add(GameObject.Find("Capsule"));

        // 리스트에서 비우기
        objList.Remove(objList[0]);

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(GameObject obj in objList)
            {
                Debug.Log(obj.name);
            }
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            objList.Clear();
        }
    }
}
