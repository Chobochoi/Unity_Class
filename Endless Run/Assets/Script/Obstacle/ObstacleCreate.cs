using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Charactor")
        {
            Debug.Log("�浹�Ǿ����ϴ�.");
        }
    }
}
