using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 게임오버 시에 텍스트 오브젝트 활성화
    public GameObject gameOverText;
    // 생존 시간
    public TextMeshProUGUI timeText;
    // 베스트 기록
    public TextMeshProUGUI bestText;

    // 생존 시간
    float surviveTime;
    // 게임 오저 상태 관리
    bool isGameover;

    private void Start()
    {
        surviveTime = 0;
        isGameover = false;

    }

    private void Update()
    {
        if(!isGameover)
        {
            // 게임 오버가 아닌 경우에만 현재 시간을 누적
            surviveTime += Time.deltaTime;
            // 생존 시간 텍스트에 생존 시간을 문자열화 하여 대입.
            timeText.text = "Time" + surviveTime.ToString();
        }
        else
        {
            if(Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene("Dodge Bullet");
            }
        }

        ExitGame();
    }

    void ExitGame()
    {
        //ESC 키를 누른다면
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 어플 종료
            Application.Quit();
        }
    }

    public void Gameover()
    {
        isGameover = true;
        gameOverText.SetActive(true);

        /*
         * PlayerPrefs란?
           임의로 값을 저장하는 것
        */

        // BestTime 키로 저장된 float값을 가져온다
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // 현재 기록이 저장된 기록보다 좋다면
        if(surviveTime > bestTime)
        {
            // 베스트 기록에 현재 기록을 대입 후 PlayerPrefs에 저장한다.
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        // UI에 기록을 출력
        bestText.text = "Best Time : " + (int)bestTime + " Sec";
    }
}
