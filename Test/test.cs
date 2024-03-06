using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationForce = 10f;
    Rigidbody rb;

/*    private void Awake()        // Start 보다 더 빠르게 실행된다.
    {
        
    }*/

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            /*Vector3 temp = new Vector3(10, 10, 10);*/
            Vector3 torque = Vector3.up * rotationForce;
            rb.AddTorque(torque, ForceMode.Impulse);
            // Impulse: 한번에 돌리는 힘
        }
    }
}
