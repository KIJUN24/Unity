using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lotto : MonoBehaviour
{
    /*int[] LottoNum = new int[46];*/

    // 1. 1~45까지의 정수를 담는 그릇
    // 같은 형식의 여러 개의 데이터를 하나의 이름으로 사용.
    // 컬렉션 : 배열, 리스트, 디셔너리

    // 로또는 45개의 공 중 6개를 뽑는 것
    // 그릇에 담긴 공의 개수는 45개에서 39개로 줄어든다.
    // 그렇기 떄문에 동적으로 크기를 변화시킬 수 있는 리스트를 사용.

    public List<int> numberList = new List<int>();

    // 45개의 공을 담아야 한다.
    int numberOFLottoBalls = 45;


    // 당첨 볼을 담을 그릇 선언
    /*int[] InputNum = new int[6];*/
    public List<int> LotteryNumbers = new List<int>();

    // 당첨 볼의 개수
    int numberOFLottory = 6;

    // 당첨 색상 배열
    // 다섯가지 배열
    public Color[] colors;
    // 인스펙터에서 초기화를 해줬기 때문에 위에 배열선언과 다르다.

    // 당첨 볼 이미지를 관리하는 배열
    public Image[] balls;

    // 당첨 번호 TMP
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
        // 스페이스바를 누를 때마다 로또 번호 추첨
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetLottoNumbers();
        }
    }

    private void GetLottoNumbers()
    {
        // 스페이스바를 누를 때 마다 리스트를 비워준다.
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
        // list.Sort()함수로 정렬
        LotteryNumbers.Sort();

        foreach (int i in LotteryNumbers)
        {
            Debug.Log($"당첨 번호 : {i}");
        }

        // UI제작
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

        // 1~10 : 노란색
        // 11~20 : 파란색
        // 21~30 : 빨간색
        // 31~40 : 회색
        // 41~45 : 녹색
        
    }
}