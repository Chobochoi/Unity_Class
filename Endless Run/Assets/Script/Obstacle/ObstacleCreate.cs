using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour
{
    public GameObject obstacle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Charactor")
        {
            ObjectPooling.objectPool.GetQueue();
        }
    }
}
