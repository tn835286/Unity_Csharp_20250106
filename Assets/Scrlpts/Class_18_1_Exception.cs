using System;
using KAI.Tools;
using Unity.VisualScripting;
using UnityEngine;

namespace KAI.Class_18
{
    /// <summary>
    /// 例外處理
    /// </summary>
    public class Class_18_1_Exception : MonoBehaviour
    {
        private void Awake()
        {
            #region 例外處理
            LogSysytem.LogWithColor($"{Division(8, 4)}", "#f33");
            LogSysytem.LogWithColor($"{Division(3, 9)}", "#f33");
            LogSysytem.LogWithColor($"{Division(7, 0)}", "#f33");

            LogSysytem.LogWithColor($"{GetScores(0)}", "#3f3");
            LogSysytem.LogWithColor($"{GetScores(4)}", "#3f3");
            LogSysytem.LogWithColor($"{GetScores(9)}", "#3f3");

            SetEnemy();
            #endregion

            try
            {
                Damage(35);
                Damage(70);
            }
            catch (Exception e)
            {
                LogSysytem.LogWithColor(e, "#fa9");
            }

            try
            {
                Cure(30);
                Cure(-10);
            }
            catch (CureValueLowerZeroException e)
            {
                LogSysytem.LogWithColor(e.Message, "#7f3");
            }
        }

        #region 例外處理
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="NumberA"></param>
        /// <param name="NumberB"></param>
        /// int? 允許傳回空值
        private int? Division(int numberA, int numberB)
        {
            // 可能發生例外的區域
            try
            {
                return numberA / numberB;       //發生例外
            }
            // 捕捉到例外為「除以零」時會執行此區域
            catch (DivideByZeroException e)
            {
                LogSysytem.LogWithColor($"分子不能為零 |{e.Message}", "#f99");
                return null;
            }
            // 最後區域
            finally
            {
                LogSysytem.LogWithColor($"例外處理完畢", "#f73");

            }
        }

        private int[] scores = { 70, 91, 64, 53, 88 };

        private int? GetScores(int index)
        {
            try
            {
                return scores[index];
            }
            catch (DivideByZeroException)
            {
                LogSysytem.LogWithColor("發生例外", "#f11");
                return null;
            }
            catch (IndexOutOfRangeException e)
            {
                LogSysytem.LogWithColor($"發生例外|{e.Message}", "#f11");
                return null;
            }
        }

        [SerializeField]
        private GameObject enemy;

        /// <summary>
        /// 設定敵人物件
        /// </summary>
        private void SetEnemy()
        {
            try
            {
                enemy.SetActive(true);      //顯示敵人物件
            }
            catch (Exception e)             //Exception 處理所有例外
            {
                LogSysytem.LogWithColor($"發生例外:{e.Message}", "#f39");
            }
        }
        #endregion
        private float hp = 100;

        private void Damage(float damage)
        {
            hp -= damage;

            if (hp <= 0)
            {
                //自訂例外
                throw new Exception("血量小於零");
            }
            else
            {
                LogSysytem.LogWithColor($"血量:{hp}", "#93f");
            }
        }

        private void Cure(float cure)
        {
            if (cure < 0)
            {
                //throw new Exception("治癒值低於零");
                throw new CureValueLowerZeroException("治癒值低於零");
            }
            else
            {
                hp += cure;
            }
        }
    }

    /// <summary>
    /// 治癒值低於零例外
    /// </summary>
    public class CureValueLowerZeroException : Exception
    {
            /// <summary>
            /// 建構子
            /// </summary>
            /// <param name="message">例外訊息</param>
        public CureValueLowerZeroException(string message) : base(message) { }
    }    
}
