using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // ���ӿ��� �ÿ� �ؽ�Ʈ ������Ʈ Ȱ��ȭ
    public GameObject gameOverText;
    // ���� �ð�
    public TextMeshProUGUI timeText;
    // ����Ʈ ���
    public TextMeshProUGUI bestText;

    // ���� �ð�
    float surviveTime;
    // ���� ���� ���� ����
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
            // ���� ������ �ƴ� ��쿡�� ���� �ð��� ����
            surviveTime += Time.deltaTime;
            // ���� �ð� �ؽ�Ʈ�� ���� �ð��� ���ڿ�ȭ �Ͽ� ����.
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
        //ESC Ű�� �����ٸ�
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // ���� ����
            Application.Quit();
        }
    }

    public void Gameover()
    {
        isGameover = true;
        gameOverText.SetActive(true);

        /*
         * PlayerPrefs��?
           ���Ƿ� ���� �����ϴ� ��
        */

        // BestTime Ű�� ����� float���� �����´�
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // ���� ����� ����� ��Ϻ��� ���ٸ�
        if(surviveTime > bestTime)
        {
            // ����Ʈ ��Ͽ� ���� ����� ���� �� PlayerPrefs�� �����Ѵ�.
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        // UI�� ����� ���
        bestText.text = "Best Time : " + (int)bestTime + " Sec";
    }
}
