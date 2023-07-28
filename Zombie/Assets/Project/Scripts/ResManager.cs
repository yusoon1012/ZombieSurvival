using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
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

    private void Awake()
    {
        dataPath = Application.dataPath;
       
        //zombieDataPath = "Assets/Project/Scriptable";

       // zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "/Zombie Data Default.asset");
        zombieDataPath = "Scriptable";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");


        zombieData_default = Resources.Load<ZombieData>(zombieDataPath);


        //캐싱

        ////ZombieData zombieData_ = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);
        //Debug.LogFormat("Zombie data path: {0}", zombieDataPath);
        //Debug.LogFormat("Zombie data path: {0},{1},{2}", zombieData_default.health, zombieData_default.damage, zombieData_default.speed);
        Debug.LogFormat("게임 save data를 여기에다가 저장하는것이 상식이다. {0}", Application.persistentDataPath);

        //AES-256이 최고수준의 보안이다.
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
