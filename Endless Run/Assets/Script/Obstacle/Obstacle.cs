using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Animator animator;
    
    public float speed = 5.0f;


    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.condition == false) return;
        
        transform.Translate(Vector3.back * speed * Time.deltaTime);
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            animator.enabled = true;
        }
    }

    // OnBecameInvisible �Լ��� Render�� ���õ� �Լ��̱� ������ MeshRenderer�� �߰��ؾ� �Ѵ�.
    // ȭ�� ������ ������ �Ǹ� ���� ������Ʈ�� ����
    private void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector3(0, 0.1f, 5);
        ObjectPooling.objectPool.InsertQueue(gameObject);
    }
}
