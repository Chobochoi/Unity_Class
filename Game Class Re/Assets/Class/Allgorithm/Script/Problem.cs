using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problem : MonoBehaviour
{
    public Text answer;

    public string input ;
    public bool condition;
    public int [] array;

    // ���׼� �ڵ�
    /*    for(int i = 0; i < variable; i++)
         {
             if(variable % 1 == 0)
             {
                 result += i;
             }

         }
         if (result > variable)
         {
             value = "���׼�";
         }
         else
         {
             value = "���׼��� �ƴմϴ�.";
         }

         answer.text = value;
     */
    // ȸ�� �Ǻ� �ڵ�
    //0  1  2  3  4
    //[] [] [] [] []
    // 0 = 4, 1 = 3 ��
    /*  for (int i = 0; i<variable.Length / 2; i++)
        {
            if (variable[i] == variable[variable.Length - i - 1])
            {
                result++;
            }

        }
        if (result == variable.Length / 2)
{
    answer.text = "ȸ��";

}
else
{
    answer.text = "ȸ���� �ƴ�";
}
      */

    // ���α׷��ӽ� 1�ܰ�
    /* �Ϻ��� ���ڿ� �Ǻ��ϱ�
    1. ���ڿ��� �Է��մϴ�.
    2. ���⿡ ���ڰ� ���� �Ǹ� "�Ϻ��� ���ڿ��� �ƴմϴ�." ���
    2-1. ���⿡ ���ڿ��� ���� �Ǹ� "�Ϻ��� ���ڿ� �Դϴ�." ���  
    �Է¹޴� ������ ���̴� �����Ӱ� 
     for (int i = 0; i < input.Length; i++)
        {
            for (int j = 48; j < 58; j++)
            {
                if (input[i] == (char)j)
                {
                    condition = true;
                }
            }
        }

        if (condition == false)
        {
            answer.text = "�Ϻ��� ���ڿ�";
        }

        else
        {
            answer = "�Ϻ��� ���ڿ� �ƴ�";
        }
*/

    // �ߺ����� �ʴ� ���� ��
    /* 1. 1~6 ������ �������� �����մϴ�. 
       2. �迭 ���·� ���� �����մϴ�.
       3. �迭�� ���̸� 5�� �����մϴ�.
       4. �������� ����������, �ߺ����� �ʵ��� ���� ����մϴ�. 
     for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 6);

            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    i--;
                }
            }
        }

        for(int i = 0; i<5; i ++)
        {
            Debug.Log(array[i]);
        }*/

    private void Start()
    {
       
    }

    private void Update()
    {
        
       
    }

}
