using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01 : MonoBehaviour
{
    /*public int inputNumber;*/
    public string answer;

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (inputNumber % 2 == 0)
            {
                Debug.Log("짝수입니다.");
            }
            else
            {
                Debug.Log("홀수입니다.");
            }
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (answer)
            {
                case "안녕":
                    Debug.Log("안녕하세요");
                    break;

                case "잘가":
                    Debug.Log("안녕히계세요");
                    break;

                default:
                    Debug.Log("무슨 일이신가요?");
                    break;
            }
        }
    }

    void Start()
    {
        /*int a = 123;
        int b = 456;
        int c = a + b;
        Debug.Log(c);

        string one = "123";
        string two = "456";
        string three = one +two;
        Debug.Log(three);

        string answer = a.ToString();
        Debug.Log(answer);

        // 후위식
        a++;
        Debug.Log($"a++ : " + a);

        // 전위식
        ++a;
        Debug.Log($"++a : " + a);
*/
        /*// divide by zero
        int i = 1;
        int j = i / 0;
        Debug.Log(j);*/



        /*for(int i=0; i<101;i++)
        {
            sum += i;
        }
        Debug.Log("1부터 100까지의 합 : " + sum);
*/

        /*for(int i=1; i<10; i++)
        {
            for(int j = 1; j<10; j++)
            {
                Debug.Log(i + " X " + j + " = " + i * j);
            }
        }*/

        int count = 0;
        int sum = 0;
        while(count <= 100)
        {
            sum += count;
            count++;
        }
        Debug.Log("1부터 100까지의 합 : " + sum);

        int number = 0;
        while (true)
        {
            Debug.Log("loop");
            number++;

            if(number >= 50)
            {
                Debug.Log("무한루프 벗어나기");
                break;
            }
        }
    }
}
