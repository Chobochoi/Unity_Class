using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{
    // Awake �Լ��� Start �Լ� ������ �� ���� ȣ��Ǵ� �Լ�
    private void Awake()
    {
        Debug.Log("Awake �Լ��Դϴ�.");
    }



    // Start is called before the first frame update
    void Start()
    {
        // �ڱ� �ڽ��� ��ġ ����
        // new Vector3(x, y, z);
     /*   transform.position = new Vector3
             (
             // x, y, z �ڱ� ��ġ
             transform.position.x,
             transform.position.y,
             transform.position.z + 1
             );
     */
        Debug.Log("Start �Լ��Դϴ�.");



        // Update is called once per frame

        /*  for (int i = 1; i <= x && i <= y; i++)
          {
              if (x % i == 0 && y % i == 0)
              {
                  result = i;
              }


          }

          Debug.Log(result); */

    }


    void Update()
    {
        Debug.Log(Time.deltaTime);
        
        if (Input.GetKey(KeyCode.A))
        {
            //Vector3.left = (-1, 0, 0);
            // 60fps : left + ������ �ӵ� * 0.016
            // 30fps : left + ������ �ӵ� + 0.03
            transform.position += Vector3.left; * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            //Vector3.forward = (0, 0, 1);
            transform.position += Vector3.forward; * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Vector3.forward = (0, 0, -1);
            transform.position += Vector3.back; * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Vector3.right = (1, 0, 0);
            transform.position += Vector3.right; * Time.deltaTime;
        }


    }

}