using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.AI;
//???
//using UnityEditor;
//빌드가 안되는경우가있다.



public class ResManager : MonoBehaviour
{

    public static ResManager instance
    {
        get
        {
            // 만약 싱글톤 변수에 아직 오브젝트가 할당되지 않았다면
            if (m_instance == null)
            {
                // 씬에서 GameManager 오브젝트를 찾아 할당
                m_instance = FindObjectOfType<ResManager>();
            }

            // 싱글톤 오브젝트를 반환
            return m_instance;
        }
    }
    private static ResManager m_instance; // 싱글톤이 할당될 static 변수

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


        //zombieDatas 초기화
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
        ////Debug.LogFormat("textCsv의 값:{0}", textCsv.text);

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

        ////캐싱
        //zombieDataPath = "Scriptable";
        //zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");
        //zombieData_default = Resources.Load<ZombieData>(zombieDataPath);
        ////캐싱


        ////ZombieData zombieData_ = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);
        //Debug.LogFormat("Zombie data path: {0}", zombieDataPath);
        //Debug.LogFormat("Zombie data path: {0},{1},{2}", zombieData_default.health, zombieData_default.damage, zombieData_default.speed);
        //Debug.LogFormat("게임 save data를 여기에다가 저장하는것이 상식이다. {0}", Application.persistentDataPath);

        //AES-256이 최고수준의 보안이다.
    }
}
    // Start is called before the first frame update

   
