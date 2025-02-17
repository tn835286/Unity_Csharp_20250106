using UnityEngine;

namespace KAI
{
    /// <summary>
    /// 練習類別
    /// </summary>
    public class practice_8_Class : MonoBehaviour
    {
        private void Awake()
        {
            practice_8_Boss BossDragon = new practice_8_Boss("龍獸", "龍之吐息", 2999);
            practice_8_Boss BossBird = new practice_8_Boss("列空座", "光束砲", 3999);

            Debug.Log($"<color=#f93>{BossDragon.name}, 招式:{BossDragon.skill}</color>");
            Debug.Log($"<color=#f93>{BossBird.name}, 招式:{BossBird.skill}</color>");
        }
    }

    /// <summary>
    /// 大魔王類別
    /// </summary>
    public class practice_8_Boss
    {
        public string name;
        public string skill;
        public float hp;

        public practice_8_Boss(string _name, string _skill, float _hp)
        {
            name = _name;
            skill = _skill;
            hp = _hp;
        }
    }
}
