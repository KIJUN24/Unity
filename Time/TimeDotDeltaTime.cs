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

        Debug.Log($"������ ����(Time.deltaTime) : {Time.deltaTime}");

        // ������ ���ݵ��� ���س����� �ᱹ ����ð��� �ȴ�.
        timerText.text = "Elapsed Time : " + timer.ToString();

        

        //  FPS(frame Per Seconds) 1�ʸ� ������ �������� ������
        float fps = 1f / Time.deltaTime;
        fpsViewer.text = "FPS : " + fps.ToString();

        // �����ð�(ms) �и�������
        // 20 �̸� : ��κ� ������ ����. ������
        // 20~50 : ������ ����� ���� �� ������ ���� ����� ������ ����
        // 50~100 : �ӵ��� �ִ� ��Ƽ ���ӿ��� ����ϴٰ� ���� �� ����.
        // 100�̻� : Ȯ���ϰ� ������ ��ٰ� ������. �÷��̰� ������.
        float ms = Time.deltaTime / 1000;
        msViewer.text = "Latency : " + ms.ToString().Substring(0, 3);
    }
}
