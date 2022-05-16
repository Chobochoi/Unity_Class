using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject target;
    private float speed = 1.0f;

    private MeshRenderer render;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }



    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards
            (
            transform.position,          //���� �ڱ� ��ġ
            target.transform.position,   // ��ǥ�� ���� ������Ʈ ��ġ
            speed * Time.deltaTime       // ���� ��ġ���� ��ǥ ��ġ�� �̵��� �ӵ�
            );
        
        // ���� ���� �� ����
        if(Input.GetKeyDown(KeyCode.Return))
        {
            // 3�ʵڿ� ��ȭ�ϰ� 
            Invoke("Paint", 3);
        }

        AutoMove();


    }

    public void AutoMove()
    {
        transform.position = new Vector3(Random.Range(0, 5), 0, Random.Range(0, 5));
    }

    public void Paint()
    {
        int value = Random.Range(0, 3);

        switch (value)
        {
            case 0:
                render.material.color = Color.green;
                break;

            case 1:
                render.material.color = Color.red;
                break;

            case 2: render.material.color = Color.black;
                break;
        }
    }
}
