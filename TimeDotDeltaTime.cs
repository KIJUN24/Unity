using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeDotDeltaTime : MonoBehaviour
{
    public float timer = 0;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI fpsViewer;
    public TextMeshProUGUI msViewer;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;

        Debug.Log($"프레임 간격(Time.deltaTime) : {Time.deltaTime}");

        // 프레임 간격들을 더해나가면 결국 경과시간이 된다.
        timerText.text = "Elapsed Time : " + timer.ToString();

        

        //  FPS(frame Per Seconds) 1초를 프레임 간격으로 나눠줌
        float fps = 1f / Time.deltaTime;
        fpsViewer.text = "FPS : " + fps.ToString();

        // 지연시간(ms) 밀리세컨드
        // 20 미만 : 대부분 느끼지 못함. 쾌적함
        // 20~50 : 예민한 사람은 느낄 수 있으나 보통 사람은 느끼지 못함
        // 50~100 : 속도감 있는 멀티 게임에서 답답하다고 느낄 수 있음.
        // 100이상 : 확실하게 지연이 길다고 느껴짐. 플레이가 불편함.
        float ms = Time.deltaTime / 1000;
        msViewer.text = "Latency : " + ms.ToString().Substring(0, 3);
    }
}
