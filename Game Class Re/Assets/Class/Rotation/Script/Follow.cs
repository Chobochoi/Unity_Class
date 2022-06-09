using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Charactor;

    void Update()
    {
        
        // �ڱ� �ڽ��� ��ġ, ĳ������ ��ġ >= 10
        if(Vector3.Distance(transform.position,Charactor.transform.position) >= 5)
        {
            // ������ ����
            // ȸ���� �ϴٰ� �� ���� ��ġ�� �Ǿ� �� ���� ������ ������� ���� �߻�
            // Quaterion ������� �̿��ؼ� x��, y��, z��, w������ ȸ���� ��ŵ�ϴ�.
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else 
        {
            // LookAt : ����� �ٶ󺸵��� �����ϴ� �Լ��Դϴ�.               
            transform.LookAt(Charactor.transform);
        }
        
        

    }
}
