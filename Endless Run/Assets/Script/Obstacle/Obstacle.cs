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

    // OnBecameInvisible 함수는 Render와 관련된 함수이기 때문에 MeshRenderer를 추가해야 한다.
    // 화면 밖으로 나가게 되면 게임 오브젝트를 삭제
    private void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector3(0, 0.1f, 5);
        ObjectPooling.objectPool.InsertQueue(gameObject);
    }
}
