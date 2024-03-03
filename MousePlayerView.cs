using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePlayerView : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 1, 0);
    Transform target;

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.position = target.position + offset;
        /*transform.position = Vector3.Lerp(transform.position, target.position + offset, 0.03f);*/
    }
}
