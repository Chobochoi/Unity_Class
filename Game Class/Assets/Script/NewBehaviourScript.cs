public class NewBehaviourScript : MonoBehaviour
{
    //�ִ�����
    /*int x = 60;
    int y = 48;

    int result = 0; */

    // Awake �Լ��� Start �Լ� ������ �� ���� ȣ��Ǵ� �Լ�
    private void Awake()
    {
        Debug.Log("Awake �Լ��Դϴ�.");
    }



    // Start is called before the first frame update
    void Start()
    {
        // �ڱ� �ڽ��� ��ġ ����
        // new Vector3(x, y, z);
         transform.position = new Vector3
              (
              // x, y, z �ڱ� ��ġ
              transform.position.x,
              transform.position.y,
              transform.position.z + 1
              );

        Debug.Log("Start �Լ��Դϴ�.");



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
            Debug.Log("Update �Լ��Դϴ�.");
        }



    }

}