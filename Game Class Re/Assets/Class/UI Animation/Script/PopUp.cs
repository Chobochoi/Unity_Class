using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    Animator animator;
    public GameObject window;
    
    void Start()
    {
        animator = window.GetComponent<Animator>();
    }

   
    void Update()
    {
        // �ִϸ����� ��Ʈ�ѷ����� ���� �ִϸ������� ������ �̸��� "Close" �� �� 
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            // ���� �ִϸ��̼��� ���൵�� 1���� ũ�ų� ������ UI�� ��Ȱ��ȭ �ϵ��� ����
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                window.SetActive(false);
            }
        }
    }

    public void Open()
    {
        window.SetActive(true);
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }
}