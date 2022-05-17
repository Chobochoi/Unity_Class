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
            transform.position,          //현재 자기 위치
            target.transform.position,   // 목표물 게임 오브젝트 위치
            speed * Time.deltaTime       // 현재 위치에서 목표 위치로 이동할 속도
            );
        
        // 엔터 누를 때 동작
        if(Input.GetKeyDown(KeyCode.Return))
        {
            // 3초뒤에 변화하게 
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
