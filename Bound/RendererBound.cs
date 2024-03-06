using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendererBound : MonoBehaviour
{
    // �ٿ�� �浹�� �浹�� ������Ʈ�� �̸� �˰��־�� �Ѵ�.
    public GameObject object1;
    public GameObject object2;

    void Update()
    {
        // �ٿ�带 Renderer�� ���� ���� �� �ִ�
        if(BoundsIntersecting(object1.GetComponent<Renderer>().bounds, object2.GetComponent<Renderer>().bounds))
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
