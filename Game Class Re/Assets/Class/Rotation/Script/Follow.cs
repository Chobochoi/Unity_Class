using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Charactor;

    void Update()
    {
        
        // 자기 자신의 위치, 캐릭터의 위치 >= 10
        if(Vector3.Distance(transform.position,Charactor.transform.position) >= 5)
        {
            // 짐벌락 현상
            // 회전을 하다가 두 축이 겹치게 되어 한 축의 역할이 사라지는 현상 발생
            // Quaterion 사원수를 이용해서 x축, y축, z축, w축으로 회전을 시킵니다.
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else 
        {
            // LookAt : 대상을 바라보도록 설정하는 함수입니다.               
            transform.LookAt(Charactor.transform);
        }
        
        

    }
}
