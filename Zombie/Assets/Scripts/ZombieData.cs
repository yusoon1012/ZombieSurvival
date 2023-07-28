using UnityEngine;

// 좀비 생성시 사용할 셋업 데이터
[CreateAssetMenu(menuName = "Scriptable/ZombieData", fileName = "Zombie Data")]
public class ZombieData : ScriptableObject {
    public float health = 100f; // 체력
    public float damage = 20f; // 공격력
    public float speed = 2f; // 이동 속도
    public Color skinColor = Color.white; // 피부색

    
}
enum ZombieLoadIndex
{
    ZOMBIE_HEALTH=1,
    ZOMBIE_DAMAGE = 2,
    ZOMBIE_SPEED = 3,
    ZOMBIE_COLOR = 4,

}
public class ZombieData2
{
    public float health = default; // 체력
    public float damage = default; // 공격력
    public float speed = default; // 이동 속도
    public Color skinColor = default; // 피부색

    public ZombieData2(string zombieDataStr)
    {
        //TODO: 데이터 넘겨받아서 초기화
        string[] zombieDatas_Str = zombieDataStr.Split(',');
        float.TryParse(zombieDatas_Str[(int)ZombieLoadIndex.ZOMBIE_HEALTH],out health);
        float.TryParse(zombieDatas_Str[(int)ZombieLoadIndex.ZOMBIE_DAMAGE], out damage);
        float.TryParse(zombieDatas_Str[(int)ZombieLoadIndex.ZOMBIE_SPEED], out speed);

        string colorHtmlCode = string.Format("#{0}FF", zombieDatas_Str[(int)ZombieLoadIndex.ZOMBIE_COLOR]);
        colorHtmlCode= colorHtmlCode.Substring(0,9);
        Color zombieColor = default;
        ColorUtility.TryParseHtmlString(colorHtmlCode, out zombieColor);

        bool isInvalid = Mathf.Approximately(health, 0f) && Mathf.Approximately(damage, 0f) && Mathf.Approximately(speed, 0f);

        if(isInvalid==true)
        {
            Debug.LogErrorFormat("[ZombieData2] Can't initialize Zombie Data");
            Debug.Assert(isInvalid);
        }
        
    }
}

