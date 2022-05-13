using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{
    // Awake 함수는 Start 함수 이전에 한 번만 호출되는 함수
    private void Awake()
    {
        Debug.Log("Awake 함수입니다.");
    }



    // Start is called before the first frame update
    void Start()
    {
        // 자기 자신의 위치 설정
        // new Vector3(x, y, z);
     /*   transform.position = new Vector3
             (
             // x, y, z 자기 위치
             transform.position.x,
             transform.position.y,
             transform.position.z + 1
             );
     */
        Debug.Log("Start 함수입니다.");



        // Update is called once per frame

        /*  for (int i = 1; i <= x && i <= y; i++)
          {
              if (x % i == 0 && y % i == 0)
              {
                  result = i;
              }


          }

          Debug.Log(result); */

    }


    void Update()
    {
        Debug.Log(Time.deltaTime);
        
        if (Input.GetKey(KeyCode.A))
        {
            //Vector3.left = (-1, 0, 0);
            // 60fps : left + 프레임 속도 * 0.016
            // 30fps : left + 프레임 속도 + 0.03
            transform.position += Vector3.left; * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            //Vector3.forward = (0, 0, 1);
            transform.position += Vector3.forward; * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Vector3.forward = (0, 0, -1);
            transform.position += Vector3.back; * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Vector3.right = (1, 0, 0);
            transform.position += Vector3.right; * Time.deltaTime;
        }


    }

}