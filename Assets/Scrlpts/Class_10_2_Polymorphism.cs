using KAI.Tools;
using UnityEngine;

namespace KAI
{
    /// <summary>
    /// 多型
    /// </summary>
    public class Class_10_2_Polymorphism : MonoBehaviour
    {
        private void Awake()
        {
            Trap trap1 = new Trap("落穴", 3);
            Magic magic = new Magic("死者甦醒", 5);

            //多型: 多種型式，可以使用父類別或者自己的成員
            trap1.Information();            // 型式 1 :呼叫父類別的無參數發法
            trap1.Information(37);          // 型式 2 :呼叫自己有一個參數的方法

            //多型: 宣告時使用父類別
            Card card1 = new Card("一般卡片", 0);
            Card magic2 = new Magic("羽毛掃", 7);
            card1.Information();            // 型式 1 :呼叫Card的方法
            magic2.Information();           // 型式 2 :呼叫Magic的方法
        }

    }

    public class Card
    {
        public string name;
        public int cost;
        public Card(string _name, int _cost)
        {
            name = _name;
            cost = _cost;
        }
        public virtual void Information()
        {
            LogSysytem.LogWithColor($"{name} 這是一張卡牌", "#aaa");
        }
    }

    public class Trap : Card
    {
        public Trap(string _name, int _cost) : base(_name, _cost)
        {
        }
        public void Information(int index)
        {
            LogSysytem.LogWithColor($"這是一張陷阱卡 編號:{index}", "#f77");
        }
    }

    public class Magic : Card
    {
        public Magic(string _name, int _cost) : base(_name, _cost)
        {
        }

        public override void Information()
        {
            LogSysytem.LogWithColor($"{name} 這是一張魔法卡", "#77f");
        }
    }
}
