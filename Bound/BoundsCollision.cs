using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCollision : MonoBehaviour
{
    // �ٿ�� �浹�� �浹�� ������Ʈ�� �̸� �˰��־�� �Ѵ�.
    // ������ٵ� ��, ������ ������� �ʴ� �浹
    public GameObject object1;
    public GameObject object2;

    void Update()
    {
        // �ٿ��� Collider �κ��� ���� �� �ִ�.
        if(BoundsIntersecting(object1.GetComponent<Collider>().bounds, object2.GetComponent<Collider>().bounds))
        {
            Debug.Log("�浹");
        }
    }

    bool BoundsIntersecting(Bounds bounds1, Bounds bounds2)
    {
        // ���� �����ϴ��� �˻� bool���� ��ȯ
        return bounds1.Intersects(bounds2);
    }
}
