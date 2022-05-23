using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorControl : MonoBehaviour
{
    public int Health = 100;
    public float speed;
    Rigidbody rigid;
    Vector3 dir;
    float x, z;
    bool condition;




    void Start()
    {
        rigid = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
        
              
            dir.x = Input.GetAxis("Horizontal");
            dir.z = Input.GetAxis("Vertical");
       

    }

    private void FixedUpdate()
    {
        rigid.MovePosition
            (
            rigid.position +
            dir *
            speed *
            Time.deltaTime
            );
    
    
     
        if (Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            // 객체에 일정한 힘을 사용 할 때
            rigid.AddForce(new Vector3(0, 300, 0));
        }
        
    }            
    

    // 물리적인 충돌을 했을 때 동작하는 함수.
    private void OnCollisionEnter(Collision collision)
    {
        
        condition = true;
       
    }


    //물리적인 충돌을 하고 있을 때 동작하는 함수.
    private void OnCollisionStay(Collision collsion)
    {
        Debug.Log("Stay");
    
    }

    // 물리적인 충돌을 벗어났을 때
    private void OnCollisionExit(Collision collsion)
    {
        
        condition = false;
    }

    // OnTrigger : 물리적인 충돌을 하지 않고 충돌 처리를 하는 함수
    // 물리적인 충돌을 하지 않고 충돌을 했을 때 동작하는 함수
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("감지");
    }

    // 물리적인 충돌을 하지 않고 충돌을 하고 있을 때 동작하는 함수
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    // 물리적인 충돌을 하지 않고 충돌을 벗어났을 때 동작하는 함수
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }


}
