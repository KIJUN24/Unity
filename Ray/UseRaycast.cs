using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseRaycast : MonoBehaviour
{
    // ����ĳ��Ʈ
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // ������ �浹 ������ ���� ����
            RaycastHit hit;
            
            // ������ ���� (���� ī�޶�κ��� ���콺 ��ġ�� ������ ���.)
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // ������ ���, (����, ��� ������ ������ ��, �Ÿ�)
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.point);
            }
        }
    }
}
