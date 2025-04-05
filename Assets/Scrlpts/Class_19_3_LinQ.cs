using System.Linq;  // 引用LinQ 命名空間
using UnityEngine;
using KAI.Tools;
using static UnityEditor.Progress;
using UnityEngine.InputSystem;

namespace KAI.Class_19_3.LinQ
{
    /// <summary>
    /// LinQ 整合查詢語言 Language Integrated Query
    /// 查詢資烙庫，所有程式語言共用技術
    /// </summary>
    public class Class_19_3_LinQ : MonoBehaviour
    {
        public int[] scores = { 90, 80, 70, 25, 50, 35, 10, 85, 99 };
        public string[] items = { "紅色藥水", "藍色藥水", "地圖", "回家卷軸", "匕首", "紅色炸彈" };
        public int[] numbers = {1, 23, 77 ,34 ,42 , 50 , 80};

        private void Awake()
        {
            #region LinQ 基本用法
            // 使用 LinQ 的關鍵字查詢資料
            // 起手式 :
            // from 資料來源
            // select 選取結果
            // 說明:選取 scores 內的每一筆分數
            var queryAllDate = from score in scores select score;

            foreach (var item in queryAllDate)
            {
                LogSysytem.LogWithColor(item, "#3f3");
            }

            // 情境 : 希望找到大於 60 分的玩家分數
            // where 篩選的條件
            // orderby 排序 (預設從小到大 descending 由大到小)
            var querySixty = from score in scores where score >= 60 orderby score descending select score;

            foreach (var item in querySixty)
            {
                LogSysytem.LogWithColor(item, "#ff3");
            }

            // 情境 : 篩選出分數為偶數的資料與奇數
            // group by
            var queryGroup = from score in scores group score by score % 2;

            foreach (var group in queryGroup)
            {
                LogSysytem.LogWithColor(group, "#f11");

                foreach (var item in group)
                {
                    LogSysytem.LogWithColor(item, "#79f");
                }

                LogSysytem.LogWithColor("--------分隔線---------", "#79f");
            }

            #endregion

            // let 中間變數，可以取得特定的資料並且儲存於變數內
            var queryRed = from item in items
                           let firstWord = item[0]  // 先取得所有資料的第一個字
                           where firstWord == '紅'
                           select item;
            foreach (var item in queryRed)
            {
                LogSysytem.LogWithColor($"第一個字是紅的道具:{item}","#fa3");
            }

            //into 將資料分組，在獲得資料時可透過 Key 獲得分組名稱
            var queryRedGroup = from item in items
                                group item by item[0] into newGroup
                                select newGroup;
            foreach (var group in queryRedGroup)
            {
                LogSysytem.LogWithColor($"群組:{group.Key}", "#3f3");
                foreach(var item in group)
                {
                    LogSysytem.LogWithColor($"道具:{item}", "#9f9");
                }
            }

            var queryEquals = from score in scores
                              join number in numbers        // 加入第二組資料
                              on score equals number        // on 比較兩組資料
                              // select score;
                              select number;                // 選兩組資料結果都相等

            foreach (var item in queryEquals)
            {
                LogSysytem.LogWithColor($"兩組相同的數字:{item}", "#f33");
            }

            LogSysytem.LogWithColor($"最大值:{queryEquals.Max()}", "#7f7");
            LogSysytem.LogWithColor($"最小值:{queryEquals.Min()}", "#7f7");
            LogSysytem.LogWithColor($"平均值:{queryEquals.Average()}", "#7f7");
            LogSysytem.LogWithColor($"總和:{queryEquals.Sum()}", "#7f7");


        }
    }
    
}
