using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problem : MonoBehaviour
{
    public Text answer;

    public string variable = "level";
    public int result = 0;

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

    

    private void Start()
    {
        //ȸ�� �Ǻ� �ڵ�
        //0  1  2  3  4
        //[] [] [] [] []
        // 0 = 4, 1 = 3 ��
        for (int i = 0; i < variable.Length / 2; i++)
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

    }



}
