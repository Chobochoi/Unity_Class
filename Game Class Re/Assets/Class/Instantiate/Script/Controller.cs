using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Horizontal : ���� ���� ������ -1 ~ 1 ������ ������ ��ȯ. LeftŰ -1 RightŰ +1
        // Vertical : ������ ���� ������ -1 ~ 1 ������ ������ ��ȯ. LeftŰ -1 RightŰ +1
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, z);
        
        // �� �����Ӹ��� �̵� ���� ��
        // normalized �� ����ؼ� ���� ���͸� �������
        // ������ ũ�⸦ �Ȱ��� 1�� ������ִ� ����

      transform.Translate(dir.normalized * Time.deltaTime * speed);

    
        
    }
   


}