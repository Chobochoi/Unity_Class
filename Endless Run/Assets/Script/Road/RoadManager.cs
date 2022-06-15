using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject road;
    List<GameObject> roadList;

    public float speed = 1.0f;

    Vector3 nextRoad = Vector3.zero;

    int firstRoad, lastRoad = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        roadList = new List<GameObject>();

        for(int i = 0; i<3; i++)
        {
            roadList.Add(Instantiate(road, nextRoad, Quaternion.identity));
            nextRoad += Vector3.forward * 36f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.condition == false) return;

        RoadMove();
    }

    void RoadMove()
    {
        // 도로의 0, 1, 2번째 배열로 설정        
        for(int i = 0; i < roadList.Count; i++)
        {
            // 리스트에 저장되어 있는 도로 전체를 Translate를 이용해서 Vector3.back 방향으로 이동
            roadList[i].transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        if (roadList[lastRoad].transform.position.z <= -36)
        {
            firstRoad = lastRoad - 1;

            if (firstRoad < 0)
            {
                firstRoad = roadList.Count - 1;
            }

            // 도로 [0] 위치                                 도로 [2] 위치
            roadList[lastRoad].transform.position = roadList[firstRoad].transform.position + Vector3.forward * 36;

            lastRoad++;

            if (lastRoad >= roadList.Count)
            {
                lastRoad = 0;
            }
        }
    }
}
