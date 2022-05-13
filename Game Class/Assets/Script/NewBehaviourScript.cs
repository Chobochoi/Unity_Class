public class NewBehaviourScript : MonoBehaviour
{
    //최대공약수
    /*int x = 60;
    int y = 48;

    int result = 0; */

    // Awake 함수는 Start 함수 이전에 한 번만 호출되는 함수
    private void Awake()
    {
        Debug.Log("Awake 함수입니다.");
    }



    // Start is called before the first frame update
    void Start()
    {
        // 자기 자신의 위치 설정
        // new Vector3(x, y, z);
         transform.position = new Vector3
              (
              // x, y, z 자기 위치
              transform.position.x,
              transform.position.y,
              transform.position.z + 1
              );

        Debug.Log("Start 함수입니다.");



        // Update is called once per frame

      /*  for (int i = 1; i <= x && i <= y; i++)
        {
            if (x % i == 0 && y % i == 0)
            {
                result = i;
            }


        }

        Debug.Log(result); */

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Update 함수입니다.");
        }



    }

}