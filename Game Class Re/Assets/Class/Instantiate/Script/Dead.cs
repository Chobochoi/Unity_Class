using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    Rigidbody rigid;
   
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // 게임 오브젝트가 화면 밖으로 이동했을 때, 동작하는 함수 입니다.
    private void OnBecameInvisible()
    {
        rigid.velocity = Vector3.zero;
        gameObject.transform.position = new Vector3(0, 5, 0);
        ObjectPool.objpool.InsertQueue(gameObject);
        
    }
}
