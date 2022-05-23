using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Horizontal : 수평에 대한 정보로 -1 ~ 1 사이의 값으로 반환. Left키 -1 Right키 +1
        // Vertical : 수직에 대한 정보로 -1 ~ 1 사이의 값으로 반환. Left키 -1 Right키 +1
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, z);
        
        // 매 프레임마다 이동 시켜 줌
        // normalized 를 사용해서 단위 벡터를 만들어줌
        // 벡터의 크기를 똑같이 1로 만들어주는 역할

      transform.Translate(dir.normalized * Time.deltaTime * speed);

    
        
    }
   


}
