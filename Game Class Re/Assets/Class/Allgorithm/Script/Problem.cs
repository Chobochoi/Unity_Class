using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problem : MonoBehaviour
{
    public Text answer;

    public string variable = "level";
    public int result = 0;

    // 과잉수 코드
    /*    for(int i = 0; i < variable; i++)
         {
             if(variable % 1 == 0)
             {
                 result += i;
             }

         }
         if (result > variable)
         {
             value = "과잉수";
         }
         else
         {
             value = "과잉수가 아닙니다.";
         }

         answer.text = value;
     */

    

    private void Start()
    {
        //회문 판별 코드
        //0  1  2  3  4
        //[] [] [] [] []
        // 0 = 4, 1 = 3 비교
        for (int i = 0; i < variable.Length / 2; i++)
        {
            if (variable[i] == variable[variable.Length - i - 1])
            {
                result++;
            }

        }
        if (result == variable.Length / 2)
        {
            answer.text = "회문";

        }
        else
        {
            answer.text = "회문이 아님";
        }

    }



}
