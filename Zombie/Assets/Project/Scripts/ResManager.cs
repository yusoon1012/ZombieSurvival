using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.AI;
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
    public string[,] csvData;
    public TextAsset textCsv;
    public string[] lines;
    public string[] columns;
    public List<ZombieData2> zombieDatas = default;
    ZombieSpawner spawner;
    private void Awake()
    {


        //zombieDatas �ʱ�ȭ
        zombieDatas = new List<ZombieData2>();
        //spawner = FindAnyObjectByType<ZombieSpawner>();
        //dataPath = Application.dataPath;
        zombieDataPath = ("ZombieDatas");
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "ZombieSurvival Datas");
        textCsv = Resources.Load<TextAsset>(zombieDataPath);

        string[] zombieDatas_Str = textCsv.text.Split('\n');
        ZombieData2 loadZombieData = default;
        for (int i = 1; i < zombieDatas_Str.Length; i++)
        {
            loadZombieData = new ZombieData2(zombieDatas_Str[i]);
            zombieDatas.Add(loadZombieData);
        }


        ////Debug.LogFormat("ZombieDataPath : {0}", zombieDataPath);
        ////Debug.LogFormat("textCsv�� ��:{0}", textCsv.text);

        ////lines = CSVToLine(textCsv.text);
        ////string[] tempArr = lines[0].Split(',');

        ////csvData = new string[lines.Length, tempArr.Length];

        ////for(int i=0;i<lines.Length;i++)
        ////{
        ////    columns = lines[i].Split(',');

        ////    for(int j=0;j<columns.Length;j++)
        ////    {
        ////        csvData[i, j] = columns[j];
        ////    }
        ////}
        ////spawner.DataInput(csvData);

        //Debug.Log(csvData[1, 0]);
        //zombieDataPath = "Assets/Project/Scriptable";

        // zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "/Zombie Data Default.asset");

        ////ĳ��
        //zombieDataPath = "Scriptable";
        //zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");
        //zombieData_default = Resources.Load<ZombieData>(zombieDataPath);
        ////ĳ��


        ////ZombieData zombieData_ = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);
        //Debug.LogFormat("Zombie data path: {0}", zombieDataPath);
        //Debug.LogFormat("Zombie data path: {0},{1},{2}", zombieData_default.health, zombieData_default.damage, zombieData_default.speed);
        //Debug.LogFormat("���� save data�� ���⿡�ٰ� �����ϴ°��� ����̴�. {0}", Application.persistentDataPath);

        //AES-256�� �ְ������ �����̴�.
    }
}
    // Start is called before the first frame update

   
