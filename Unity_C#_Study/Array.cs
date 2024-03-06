using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    /*
     * new 키워드를 사용하여 인스턴스화(메모리에 할당, 실제 사용한 객체로 만드는 것)
     * [3]은 3개를 담는 그릇을 의미(크기)
     * index는 0부터 (주의)
     * 동적으로 크기를 변경할 수 없음 (그릇의 크기가 가변적이지 않고 고정일 때 사용)
    */

    int[] intArray1 = new int[3];

    // 초기화와 동시에 값을 대입할 수도 있다.
    int[] intArray2 = { 10, 20, 30 };

    int[] intArray3 = new int[21];
    // public 접근제한자를 사용하여  inspector에 노출시켜 사용할 수 있다.
    public GameObject[] objArray;

    void Start()
    {
        // 준비된 그릇에 필요할 때 값을 대입하는 방식
        intArray1[0] = 0;
        intArray1[1] = 1;
        intArray1[2] = 2;

        /*Debug.Log("intArray1 출력");
        for(int i = 0;i<intArray1.Length;i++)
        {
            Debug.Log(intArray1[i]);
        }


        Debug.Log("\nintArray2 출력");*/
        // foreach : 그릇의 크기만큼 반복해준다.

        // foreach의 원형
        // foreach( 데이터 타입 변수명 in 그릇 )
        // { }
        /*foreach(int i in intArray2)
        {
            Debug.Log(i);
        }
*/
        
        
        Debug.Log("1부터 20까지");
        for(int i=1;i<intArray3.Length;i++)
        {
            intArray3[i] = i;
            Debug.Log("intArray3 : " + intArray3[i]);
        }

    }

}
