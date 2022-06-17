using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ���ӸŴ����� �ν��Ͻ��� ��� ��������
    // �� ���� ������ ���� �Ŵ��� �ν��Ͻ��� �� instance�� ��� ������Ʈ�� ���� �� �� ����
    public static GameManager instance;

    public bool condition = true;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            // ���� ��ȯ�Ǵ��� �ı����� �ʰ� ������ �� �ֵ��� ����
            DontDestroyOnLoad(instance);

        }

        else
        {
            // ���� ���� �̵����� �� �� ������ ���� �Ŵ����� �����ϰ� �Ǹ� �ڱ� �ڽ��� ����
            Destroy(instance);
        }
    }
}
