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
    // 회문 판별 코드
    //0  1  2  3  4
    //[] [] [] [] []
    // 0 = 4, 1 = 3 비교
    /*  for (int i = 0; i<variable.Length / 2; i++)
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
      */

    // 프로그래머스 1단계
    /* 완벽한 문자열 판별하기
    1. 문자열을 입력합니다.
    2. 여기에 숫자가 들어가게 되면 "완벽한 문자열이 아닙니다." 출력
    2-1. 여기에 문자열만 들어가게 되면 "완벽한 문자열 입니다." 출력  
    입력받는 문자의 길이는 자유롭게 
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
            answer.text = "완벽한 문자열";
        }

        else
        {
            answer = "완벽한 문자열 아님";
        }
*/

    // 중복되지 않는 랜덤 값
    /* 1. 1~6 사이의 난수값을 생성합니다. 
       2. 배열 형태로 값을 저장합니다.
       3. 배열의 길이를 5로 설정합니다.
       4. 난수값을 생성하지만, 중복되지 않도록 값을 출력합니다. 
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
