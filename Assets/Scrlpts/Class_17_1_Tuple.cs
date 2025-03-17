using KAI.Tools;
using UnityEngine;

namespace KAI.Class_17
{
    /// <summary>
    /// 元組
    /// </summary>
    public class Class_17_1_Tuple : MonoBehaviour
    {
        private void Awake()
        {
            //元組:儲存多筆不同類型的資料
            //宣告方式 1 :指定類型與名稱
            (string name, int cost, int index) card1 = ("史萊姆", 1, 7);
            LogSysytem.LogWithColor($"{card1.name} | 消耗:{card1.cost} | 編號:{card1.index}", "#f49");

            //宣告方式 2：指定類型
            //取得元組資料時使用 Item1 ~ ItemN
            (string, int, int) card2 = ("哥布林", 2, 23);
            LogSysytem.LogWithColor($"{card2.Item1} | 消耗:{card2.Item2} | 編號:{card2.Item3}", "#f49");

            //宣告方式 3 ： 使用 var
            var card3 = ("樹精", 4, 50);
            LogSysytem.LogWithColor($"{card3.Item1} | 消耗:{card3.Item2} | 編號:{card3.Item3}", "#f49");

            //宣告方式 4 ： 使用 var 以及指名
            var card4 = (name: "蝙蝠", cost: 2, index: 6);
            LogSysytem.LogWithColor($"{card4.name} | 消耗:{card4.cost} | 編號:{card4.index}", "#f49");

            UseCard(card1);
            UseCard(card2);
            UseCard(("暴龍", 7, 99));
        }

        /// <summary>
        /// 使用卡牌
        /// </summary>
        /// <param name="card">卡牌元組，名稱、消耗與編號</param>
        private void UseCard((string name, int cost, int index) card)
        {
            LogSysytem.LogWithColor($"消耗{card.cost} 使用卡牌:{card.name}", "#7f7");
        }
    }

    

    
    
}
