using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    /*
     * new Ű���带 ����Ͽ� �ν��Ͻ�ȭ(�޸𸮿� �Ҵ�, ���� ����� ��ü�� ����� ��)
     * [3]�� 3���� ��� �׸��� �ǹ�(ũ��)
     * index�� 0���� (����)
     * �������� ũ�⸦ ������ �� ���� (�׸��� ũ�Ⱑ ���������� �ʰ� ������ �� ���)
    */

    int[] intArray1 = new int[3];

    // �ʱ�ȭ�� ���ÿ� ���� ������ ���� �ִ�.
    int[] intArray2 = { 10, 20, 30 };

    int[] intArray3 = new int[21];
    // public ���������ڸ� ����Ͽ�  inspector�� ������� ����� �� �ִ�.
    public GameObject[] objArray;

    void Start()
    {
        // �غ�� �׸��� �ʿ��� �� ���� �����ϴ� ���
        intArray1[0] = 0;
        intArray1[1] = 1;
        intArray1[2] = 2;

        /*Debug.Log("intArray1 ���");
        for(int i = 0;i<intArray1.Length;i++)
        {
            Debug.Log(intArray1[i]);
        }


        Debug.Log("\nintArray2 ���");*/
        // foreach : �׸��� ũ�⸸ŭ �ݺ����ش�.

        // foreach�� ����
        // foreach( ������ Ÿ�� ������ in �׸� )
        // { }
        /*foreach(int i in intArray2)
        {
            Debug.Log(i);
        }
*/
        
        
        Debug.Log("1���� 20����");
        for(int i=1;i<intArray3.Length;i++)
        {
            intArray3[i] = i;
            Debug.Log("intArray3 : " + intArray3[i]);
        }

    }

}
