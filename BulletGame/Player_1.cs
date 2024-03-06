using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float moveSpeed = 0f;

    private void Update()
    {
        // �÷��̾� (����)�̵� ���
        /*PlayerRigidMove();   // �巡�� -> ���� �۾� �� �����͸� -> �޼��� ����*/
        PlayerAxisVelocityMove();
    }
    // �����̵�
    #region
    private void PlayerRigidMove()
    {
        // GetKey : ������ ������ ����, GetKeyDown : ���� �� �� ���� ����
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidbody.AddForce(0, 0, moveSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.AddForce(0, 0, -moveSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddForce(moveSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddForce(-moveSpeed, 0, 0);
        }
    }
    #endregion

    // Ű �Է¿� ���� �� �̵�
    void PlayerAxisVelocityMove()
    {
        // �࿡ ���� �Է°��� ������ -1 ~ 1����
        float inputX = 0.0f, inputZ = 0.0f;
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        /*Debug.Log("x�� �Է� �� : " + inputX + "\ty�� �Է� �� : " + inputY);*/

        Vector3 newVelocity = new Vector3(inputX, 0, inputZ) * moveSpeed;
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);

        // GameManager ��ũ��Ʈ�� ���� ��ü�� �����´�.
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.Gameover();
    }
}
