using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 1. Ű���� �Է� �Ǵ� ���콺 �Է��� ���� ���ϴ� �������� �ϸ鼭 �̵��ϴ� �ڵ带 �ۼ��غ�����.

    // 2. ���� �����ϼ���

    // 3. ���� �浹 �� ���� Destory�ϼ���.




    Vector3 target;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                target = hit.point;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, target, 3f * Time.deltaTime);
    }
}
