using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lotto : MonoBehaviour
{
    /*int[] LottoNum = new int[46];*/

    // 1. 1~45������ ������ ��� �׸�
    // ���� ������ ���� ���� �����͸� �ϳ��� �̸����� ���.
    // �÷��� : �迭, ����Ʈ, ��ųʸ�

    // �ζǴ� 45���� �� �� 6���� �̴� ��
    // �׸��� ��� ���� ������ 45������ 39���� �پ���.
    // �׷��� ������ �������� ũ�⸦ ��ȭ��ų �� �ִ� ����Ʈ�� ���.

    public List<int> numberList = new List<int>();

    // 45���� ���� ��ƾ� �Ѵ�.
    int numberOFLottoBalls = 45;


    // ��÷ ���� ���� �׸� ����
    /*int[] InputNum = new int[6];*/
    public List<int> LotteryNumbers = new List<int>();

    // ��÷ ���� ����
    int numberOFLottory = 6;

    // ��÷ ���� �迭
    // �ټ����� �迭
    public Color[] colors;
    // �ν����Ϳ��� �ʱ�ȭ�� ����� ������ ���� �迭����� �ٸ���.

    // ��÷ �� �̹����� �����ϴ� �迭
    public Image[] balls;

    // ��÷ ��ȣ TMP
    TextMeshProUGUI[] numberTexts = new TextMeshProUGUI[6];

    void Awake()
    {
        for(int i=0; i<balls.Length; i++)
        {
            numberTexts[i] = balls[i].GetComponentInChildren<TextMeshProUGUI>();
        }
    }

    void Start()
    {
        GetLottoNumbers();
    }

    void Update()
    {
        // �����̽��ٸ� ���� ������ �ζ� ��ȣ ��÷
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetLottoNumbers();
        }
    }

    private void GetLottoNumbers()
    {
        // �����̽��ٸ� ���� �� ���� ����Ʈ�� ����ش�.
        numberOFLottoBalls = 45;
        numberList.Clear();
        LotteryNumbers.Clear();


        for (int i = 1; i <= numberOFLottoBalls; i++)
        {
            numberList.Add(i);
        }

        for (int i = 0; i < numberOFLottory; i++)
        {
            int lottoeryIndex = Random.Range(0, numberOFLottoBalls);
            LotteryNumbers.Add(numberList[lottoeryIndex]);
            numberList.Remove(numberList[lottoeryIndex]);
            numberOFLottoBalls--;
        }
        // list.Sort()�Լ��� ����
        LotteryNumbers.Sort();

        foreach (int i in LotteryNumbers)
        {
            Debug.Log($"��÷ ��ȣ : {i}");
        }

        // UI����
        for(int i=0; i<LotteryNumbers.Count;i++)
        {
            numberTexts[i].text = LotteryNumbers[i].ToString();
            int num;
            num = int.Parse(numberTexts[i].text);
            if (num>=1 && num<=10)
            {
                balls[i].color = colors[0];
            }
            else if(num >= 11 && num <= 20)
            {
                balls[i].color = colors[1];
            }
            else if(num >= 21 && num <= 30)
            {
                balls[i].color = colors[2];
            }
            else if (num >= 31 && num <= 40)
            {
                balls[i].color = colors[3];
            }
            else
            {
                balls[i].color = colors[4];
            }

            /*if(LotteryNumbers[i] <= 10)
            {

            }
            else(LotteryNumbers[i]> 10 && LotteryNumbers[i] <= 20)
            {

            }*/


        }

        // 1~10 : �����
        // 11~20 : �Ķ���
        // 21~30 : ������
        // 31~40 : ȸ��
        // 41~45 : ���
        
    }
}