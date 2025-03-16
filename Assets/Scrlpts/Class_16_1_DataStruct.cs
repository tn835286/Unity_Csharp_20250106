using System.Collections.Generic;   //有許多資料結構的命名空間
using KAI.Tools;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

namespace KAI.Class_16
{
    /// <summary>
    /// 資料結構
    /// </summary>
    public class Class_16_1_DataStruct : MonoBehaviour
    {
        // 陣列
        public int[] attacks = { 10, 15, 7 };
        public float[] defens = { 1.5f, 7.5f, 0.3f };

        // 清單:泛型集合
        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> props = new List<string>() { "藥水", "地圖" };
        public List<float> playerDefens;

        private void Awake()
        {
            #region 清單
            // 清單存取:與陣列相同
            LogSysytem.LogWithColor($"第三筆速度:{speeds[2]}", "#3f3");
            speeds[0] = 10;
            LogSysytem.LogWithColor($"第一筆速度:{speeds[0]}", "#3f3");
            // 陣列初始化後就無法增減長度
            // 添加一筆道具
            props.Add("寶劍");
            // 刪除第一筆道具
            props.RemoveAt(0);
            // 添加頭盔到編號1上
            props.Insert(1, "頭盔");

            foreach (var prop in props)
            {
                LogSysytem.LogWithColor($"道具:{prop}", "#f93");
            }

            // 使用建構子帶入陣列
            playerDefens = new List<float>(defens);
            // 排序:由小到大
            playerDefens.Sort();
            // 反排序:由大到小
            playerDefens.Reverse();

            foreach (var item in playerDefens)
            {
                LogSysytem.LogWithColor($"資料:{item}", "#f93");
            }

            // Count 指清單內的資料，根據 Add 或 Remove 改變
            LogSysytem.LogWithColor($"數量:{props.Count}", "#77f");
            // Capcity 指清單內的容量，系統自動分配，預射為 4 並且以倍數成長(C# 各版本不同
            LogSysytem.LogWithColor($"容量:{props.Capacity}", "#77f");

            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
                LogSysytem.LogWithColor($"數量:{numbers.Count}", "#3a3");
                LogSysytem.LogWithColor($"容量:{numbers.Capacity}", "#f39");
            }
            #endregion

            #region 堆疊
            // 堆疊 : 先進後出
            Stack<string> enemys = new Stack<string>();
            // 放資料進入堆疊
            enemys.Push("史萊姆");
            enemys.Push("哥布林");
            LogStack<string>(enemys);
            // 拿資料並且不移除
            var peek = enemys.Peek();
            LogSysytem.LogWithColor(peek, "#78f");
            LogStack<string>(enemys);
            // 拿資料並且移除
            var pop = enemys.Pop();
            LogSysytem.LogWithColor(pop, "#78f");
            LogStack<string>(enemys);
            //判斷是否包含某筆資料
            LogSysytem.LogWithColor($"{enemys.Contains("哥布林")}", "#3f6");
            //清除所有資料
            enemys.Clear();
            LogStack<string>(enemys);
            #endregion

            // Queue佇列 : 先進先出，先放進來的資料先被拿出，回來遊戲的攻擊順序
            Queue<string>player = new Queue<string>();
            player.Enqueue("盜賊");
            player.Enqueue("法師");
            player.Enqueue("戰士");
            LogQueue<string>(player);
            // 拿東西不刪除，與堆疊的 Peek 相同
            LogSysytem.LogWithColor(player.Peek(), "#f33");
            LogQueue<string>(player);
            // 拿東西並刪除，與堆疊的 Pop 相同
            LogSysytem.LogWithColor(player.Dequeue(), "#f33");
            LogQueue<string>(player);
        }

        private void LogStack<T>(Stack<T> stack)
        {
            LogSysytem.LogWithColor("----------------", "#fff");
            foreach (var item in stack)
            {
                LogSysytem.LogWithColor($"堆疊資料:{item}", "#f77");
            }
        }

        private void LogQueue<T>(Queue<T> queue)
        {
            LogSysytem.LogWithColor("------------", "#fff");
            foreach(var item in queue)
            {
                LogSysytem.LogWithColor($"佇列資料:{item}", "#7f7");
            }
        }
    }
    
}
