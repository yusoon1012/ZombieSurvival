using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//???
//using UnityEditor;
//���尡 �ȵǴ°�찡�ִ�.



public class ResManager : MonoBehaviour
{
    public static ResManager instance
    {
        get
        {
            // ���� �̱��� ������ ���� ������Ʈ�� �Ҵ���� �ʾҴٸ�
            if (m_instance == null)
            {
                // ������ GameManager ������Ʈ�� ã�� �Ҵ�
                m_instance = FindObjectOfType<ResManager>();
            }

            // �̱��� ������Ʈ�� ��ȯ
            return m_instance;
        }
    }
    private static ResManager m_instance; // �̱����� �Ҵ�� static ����

    private string dataPath = default;
    private static string zombieDataPath = default;
    public ZombieData zombieData_default = default;

    private void Awake()
    {
        dataPath = Application.dataPath;
       
        //zombieDataPath = "Assets/Project/Scriptable";

       // zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "/Zombie Data Default.asset");
        zombieDataPath = "Scriptable";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");


        zombieData_default = Resources.Load<ZombieData>(zombieDataPath);


        //ĳ��

        ////ZombieData zombieData_ = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);
        //Debug.LogFormat("Zombie data path: {0}", zombieDataPath);
        //Debug.LogFormat("Zombie data path: {0},{1},{2}", zombieData_default.health, zombieData_default.damage, zombieData_default.speed);
        Debug.LogFormat("���� save data�� ���⿡�ٰ� �����ϴ°��� ����̴�. {0}", Application.persistentDataPath);

        //AES-256�� �ְ������ �����̴�.
    }
    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
