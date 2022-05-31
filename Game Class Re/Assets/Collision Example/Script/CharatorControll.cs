using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharatorControll : MonoBehaviour  
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            //AddForce : °´Ã¼¿¡ ÈûÀ» °¡ÇÏ´Â ÇÔ¼ö
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay");
    }

    private void OnCollisionExit(Collision collision)
    {
        condition = false;
    }

    private void FixedUpdate()
    {
        rigid.MovePosition
            (
            rigid.position + direction.normalized *
            speed * Time.fixedDeltaTime
            );

    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }
}
