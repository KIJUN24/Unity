using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float moveSpeed = 0f;

    private void Update()
    {
        // 플레이어 (물리)이동 담당
        /*PlayerRigidMove();   // 드래그 -> 빠른 작업 및 리펙터링 -> 메서드 추출*/
        PlayerAxisVelocityMove();
    }
    // 물리이동
    #region
    private void PlayerRigidMove()
    {
        // GetKey : 누르는 동안을 감지, GetKeyDown : 누를 때 한 번만 감지
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

    // 키 입력에 의한 축 이동
    void PlayerAxisVelocityMove()
    {
        // 축에 의한 입력값의 범위는 -1 ~ 1까지
        float inputX = 0.0f, inputZ = 0.0f;
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        /*Debug.Log("x축 입력 값 : " + inputX + "\ty축 입력 갑 : " + inputY);*/

        Vector3 newVelocity = new Vector3(inputX, 0, inputZ) * moveSpeed;
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);

        // GameManager 스크립트를 지닌 객체를 가져온다.
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.Gameover();
    }
}
