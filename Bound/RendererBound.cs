using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendererBound : MonoBehaviour
{
    // 바운드 충돌은 충돌할 오브젝트를 미리 알고있어야 한다.
    public GameObject object1;
    public GameObject object2;

    void Update()
    {
        // 바운드를 Renderer로 부터 얻어올 수 있다
        if(BoundsIntersecting(object1.GetComponent<Renderer>().bounds, object2.GetComponent<Renderer>().bounds))
        {
            Debug.Log("충돌");
        }
    }

    bool BoundsIntersecting(Bounds bounds1, Bounds bounds2)
    {
        // 서로 교차하는지 검사 bool값을 반환
        return bounds1.Intersects(bounds2);
    }
}
