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
            // ��ü�� ������ ���� ��� �� ��
            rigid.AddForce(new Vector3(0, 300, 0));
        }
        
    }            
    

    // �������� �浹�� ���� �� �����ϴ� �Լ�.
    private void OnCollisionEnter(Collision collision)
    {
        
        condition = true;
       
    }


    //�������� �浹�� �ϰ� ���� �� �����ϴ� �Լ�.
    private void OnCollisionStay(Collision collsion)
    {
        Debug.Log("Stay");
    
    }

    // �������� �浹�� ����� ��
    private void OnCollisionExit(Collision collsion)
    {
        
        condition = false;
    }

    // OnTrigger : �������� �浹�� ���� �ʰ� �浹 ó���� �ϴ� �Լ�
    // �������� �浹�� ���� �ʰ� �浹�� ���� �� �����ϴ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("����");
    }

    // �������� �浹�� ���� �ʰ� �浹�� �ϰ� ���� �� �����ϴ� �Լ�
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    // �������� �浹�� ���� �ʰ� �浹�� ����� �� �����ϴ� �Լ�
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }


}
