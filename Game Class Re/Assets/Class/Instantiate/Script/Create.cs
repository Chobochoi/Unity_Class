using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject obj;

    
    // Start is called before the first frame update
    void Start()
    {
        //오늘의 문제. 게임 오브젝트를 3개 동시에 생성해보자
        // x축을 3의 배수 간격으로 생성시켜라


        // 생성할 게임 오브젝트, 위치 회전
        // Quaternion.identity = 회전값이 0, 0, 0을 초기화합니다.
        for (int i = 1; i < 4; i++)
        {
            Instantiate(obj, new Vector3(3 * i, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
