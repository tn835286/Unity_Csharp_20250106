using System;
using KAI.Tools;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;

namespace KAI
{
    /// <summary>
    /// 事件:當一件事情發生後會通知所有系統
    /// 需要對應處理的系統可以訂閱並做出整理
    /// 遊戲範例:死亡事件
    /// GM 死亡事件，當角色死亡會執行死亡事件通知其他系統
    /// 控制系統 > 訂閱死亡事件 > 停止控制系統
    /// 音樂系統 > 訂閱死亡事件 > 變更BGM
    /// </summary>
    public class Class_19_2_Event : MonoBehaviour
    {
        // 事件使用步驟
        // 1. 宣告事件(委派)
        // 2. 呼叫事件 (什麼時間點要觸發)
        // 3. 其他系統訂閱事件
        private float hp = 10;

        // 步驟 1. 宣告事件
        public delegate void delegeteMethod();

        // 事件關鍵字 : event
        public event delegeteMethod onDead;

        public event Action<string, float> onDeadAction;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) Damage(5);
        }

        private void Damage(float damage)
        {
            hp -= damage;

            if(hp <= 0)
            {
                LogSysytem.LogWithColor("玩家死亡", "#f99");
                // 步驟 2. 呼叫事件
                onDead?.Invoke();                     // ?問號 :判斷onDead 如果有訂閱者才會呼叫

                onDeadAction?.Invoke("玩家", hp);     // 事件有參數時呼叫要帶入              
            }
        }
    }
    
}
