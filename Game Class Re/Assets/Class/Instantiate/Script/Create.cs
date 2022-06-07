using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject Prefab;

    // Update is called once per frame
    public void PrefabCreate()
    {
        ObjectPool.objpool.GetQueue();
    }
}
