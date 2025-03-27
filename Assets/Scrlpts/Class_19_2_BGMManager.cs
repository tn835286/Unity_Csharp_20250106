using KAI.Tools;
using UnityEngine;

namespace KAI
{
    /// <summary>
    /// 背景音樂管理器
    /// </summary>
    public class Class_19_2_BGMManager : MonoBehaviour
    {
        [SerializeField]
        private Class_19_2_Event Class_19_2_Event;

        // 步驟 3. 訂閱事件 (Unity 習慣在Awake 或 Start 訂閱)
        private void Awake()
        {
            // 事件:輸入 += 可以使用 Tab 自動完成 > 命名方法後 > Enter 完成
            Class_19_2_Event.onDead += ChangeBGM;
            Class_19_2_Event.onDeadAction += ChangeBGMViaHp;
        }

        private void ChangeBGMViaHp(string arg1, float arg2)
        {
            LogSysytem.LogWithColor($"{arg1}, |血量:{arg2}","#78f");
            if (arg2 <= -5) LogSysytem.LogWithColor("變更為遊戲結束音樂", "#777");
        }

        private void ChangeBGM()
        {
            LogSysytem.LogWithColor("變更音樂", "#3f3");
        }
    
    }
    
}
