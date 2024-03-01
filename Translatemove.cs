using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translatemove : MonoBehaviour
{

    public float speed = 1f;
    
    Vector3 originPosition = Vector3.zero;
    Vector3 currentPosition = Vector3.zero;

    // ��ŭ�� �ð����� �̵��Ͽ�����
    float moveTime;

    void Start()
    {
        originPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log(Time.deltaTime);*/
        float inputH = Input.GetAxis("Horizontal");     // �¿� ȭ��ǥ
        float inputV = Input.GetAxis("Vertical");       


        // ������ ����ȭ (ũ�Ⱑ 1�� ���ͷ� ����� ��.
        // ��, ũ��� 1�� �����ϰ� ���Ⱚ�� ������ �ȴ�.
        // �밢������ �� �� �ӵ��� �޶����� ���� ������ �� ����.
        Vector3 movement = new Vector3(inputH, 0f, inputV).normalized;


        // Ű�� ������ ��
        if(movement.magnitude > 0)
        {
            // Translate() �Լ��� � �Ű������� ���°�?
            // ù ��° �Ű����� : ���� ��ȭ��ų��
            // �� ��° �Ű����� : ������ ����
            
            transform.Translate(movement * Time.deltaTime * speed, Space.World);
            // Time.deltTime�� �����ִ� ����
            // : movement * Time.deltatime�� ���ָ� ������ ����, �� ���� pc�� ��� (FPS)������ ������ �ȴ�.

            // Ű�� ���� ������ �ð�
            moveTime += Time.deltaTime;
            if(moveTime >= 1f)
            {
                currentPosition = transform.position;
                float distance = Vector3.Distance(originPosition, currentPosition);
                float speed = distance / moveTime;
                Debug.Log($"�ʴ� �ӷ� : {speed}");

                originPosition = currentPosition;
                moveTime = 0f;
            }
        }

        // �ӷ� : �Ÿ� / �ð�
        // �Ÿ� : Vector3.Distance(A,B) : A�� B������ �Ÿ�(float)

    }
}
