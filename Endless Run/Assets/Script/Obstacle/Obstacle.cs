using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5.0f;


    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.back * speed * Time.deltaTime);
     
    }


    // OnBecameInvisible �Լ��� Render�� ���õ� �Լ��̱� ������ MeshRenderer�� �߰��ؾ� �Ѵ�.
    // ȭ�� ������ ������ �Ǹ� ���� ������Ʈ�� ����
    private void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector3(0, 0, 5);
        ObjectPooling.objectPool.InsertQueue(gameObject);
    }
}