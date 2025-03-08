using KAI.Tools;
using Unity.VisualScripting;
using UnityEngine;

namespace KAI
{
    /// <summary>
    /// 繼承 inherit
    /// </summary>
    public class Class_10_1_Inherit : MonoBehaviour
    {
        private void Awake()
        {
            var goblin1 = new Goblin(10, 1);
            LogSysytem.LogWithColor($"哥布林1號的攻擊:{goblin1.attack}", "#f3d");
            var slime1 = new Slime(3, 2);
            LogSysytem.LogWithColor($"史萊姆1號的攻擊:{slime1.attack}", "#f3d");
        }
    }

    public class Goblin
    {
        public int attack;         //公開
        public int defense;
        private float moveSpeed;   //私人:此類別可以存取 
        protected float hp;          //保護:子類別可以存取 

        public Goblin(int _attack,int _defense)
        {
            attack = _attack;
            defense = _defense;
        }
    }

    // 繼承讓類別可以繼承另一個類別，擁有該類別的成員
    // 子類別 : 父類別
    // C# 僅提供單一繼承 (只能繼承一個類別
    public class Slime : Goblin
    {
        public Slime(int _attack,int _defense) : base(_attack,_defense)
        {
        }

        public void Initlize()
        {
            attack = 7;             //公開:可以存取
            // moveSpeed = 3.5f;    //私人:無法存取
            hp = 10;                //保護:可以存取
        }
    }
}
