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
        // ������ 0, 1, 2��° �迭�� ����        
        for(int i = 0; i < roadList.Count; i++)
        {
            // ����Ʈ�� ����Ǿ� �ִ� ���� ��ü�� Translate�� �̿��ؼ� Vector3.back �������� �̵�
            roadList[i].transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        if (roadList[lastRoad].transform.position.z <= -36)
        {
            firstRoad = lastRoad - 1;

            if (firstRoad < 0)
            {
                firstRoad = roadList.Count - 1;
            }

            // ���� [0] ��ġ                                 ���� [2] ��ġ
            roadList[lastRoad].transform.position = roadList[firstRoad].transform.position + Vector3.forward * 36;

            lastRoad++;

            if (lastRoad >= roadList.Count)
            {
                lastRoad = 0;
            }
        }
    }
}
