using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject obj;

    
    // Start is called before the first frame update
    void Start()
    {
        //������ ����. ���� ������Ʈ�� 3�� ���ÿ� �����غ���
        // x���� 3�� ��� �������� �������Ѷ�


        // ������ ���� ������Ʈ, ��ġ ȸ��
        // Quaternion.identity = ȸ������ 0, 0, 0�� �ʱ�ȭ�մϴ�.
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
