using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // List �ʱ�ȭ�� ����
    // ���� �� ����������(����) ũ�Ⱑ ���� �� �ִ�.
    public List<GameObject> objList = new List<GameObject>();

    void Start()
    {
        // ����Ʈ ����
        objList.Clear();

        // ����Ʈ �߰�
        objList.Add(GameObject.Find("Cube"));
        objList.Add(GameObject.Find("Plane"));
        objList.Add(GameObject.Find("Sphere"));
        objList.Add(GameObject.Find("Capsule"));

        // ����Ʈ���� ����
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
