using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject origin;
    public float speed = 1.0f; 

   
    // 예제1. 스페이스를 눌렀을 때 속도가 10 증가하도록 설정합니다.
    // 예제2. 그리고 속도가 100이상 넘어가게 되면 다시 0으로 설정합니다.

    // Update is called once per frame
    void Update()
    {
       if(speed >= 100)
        {
            speed = 0;
        }
        
        // 회전을 하기 위한 축
        transform.RotateAround(origin.transform.position, Vector3.down, speed * Time.deltaTime);
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            speed += 10;
        }

        

    }
}
