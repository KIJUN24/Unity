using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // ��ü�� �ӷ��� Ʈ�������� ���ʹ��� * speed�� ����.
        rb.velocity = transform.forward * speed;

        // ������Ʈ �ı� �Լ� �Ű����� 2���� (�ı���ų ������Ʈ, �ð� ���(�� �� ��))
        Destroy(gameObject, 3f);
    }

    // Ʈ���� �浹 ���۵� �� �Ű����� (Ŭ���̴�)
    private void OnTriggerEnter(Collider other)
    {
        // Ŭ���̴��� �±װ� Player�� ���ٸ�,
        if(other.tag == "Player")
        {

        }
        // �� �ڵ�� ����
        // CompareTag�� ���� ����.
        if (other.CompareTag("Player"))
        {
            Debug.Log("�浹");

            // �÷��̾� ����, Ʈ���� �浹�� other���� Player ��ũ��Ʈ ������
            Player_1 player = other.GetComponent<Player_1>();

            // �÷��̾� �������� �� �����ߴٸ�,
            if(player != null)  // Ȥ�� �� ������ �����ϱ� ����
            {
                // Die() �Լ� ����
                player.Die();
                Debug.Log("Player Die");
            }

        }
    }


    /*
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("�浹 ��");

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("�浹 ��");

    }*/
}
