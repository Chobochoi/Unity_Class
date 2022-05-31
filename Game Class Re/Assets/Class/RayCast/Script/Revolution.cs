using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject origin;
    public float speed = 1.0f; 

   
    // ����1. �����̽��� ������ �� �ӵ��� 10 �����ϵ��� �����մϴ�.
    // ����2. �׸��� �ӵ��� 100�̻� �Ѿ�� �Ǹ� �ٽ� 0���� �����մϴ�.

    // Update is called once per frame
    void Update()
    {
       if(speed >= 100)
        {
            speed = 0;
        }
        
        // ȸ���� �ϱ� ���� ��
        transform.RotateAround(origin.transform.position, Vector3.down, speed * Time.deltaTime);
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            speed += 10;
        }

        

    }
}
