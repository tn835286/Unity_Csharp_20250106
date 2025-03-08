using KAI.Tools;
using UnityEditor.Build;
using UnityEngine;
using System;

namespace KAI
{
    /// <summary>
    /// 資料類型轉換
    /// </summary>
    public class Class_9_2_DataTypeSwitch:MonoBehaviour
    {
        private void Awake()
        {
            // 隱式轉換：不需要另外宣告轉換類型
            // 將小的資料放到大的資料內
            byte byte1 = 1;
            int int1 = 0;
            LogSysytem.LogWithColor(byte1, "#7f7");
            LogSysytem.LogWithColor(byte1.GetType(), "#7f7");
            LogSysytem.LogWithColor(int1, "#7f7");
            LogSysytem.LogWithColor(int1.GetType(), "#7f7");
            // 隱式轉換：將比較小的 byte 放到大的 int
            int1 = byte1;
            LogSysytem.LogWithColor(int1, "#7f7");
            LogSysytem.LogWithColor(int1.GetType(), "#7f7");

            // 顯示轉換：需要宣告轉換類型
            // 將大的資料放到小的資料內
            int int2 = 100;
            byte byte2 = 0;
            LogSysytem.LogWithColor(int2, "#7f7");
            LogSysytem.LogWithColor(int2.GetType(), "#7f7");
            LogSysytem.LogWithColor(byte2, "#7f7");
            LogSysytem.LogWithColor(byte2.GetType(), "#7f7");
            // 顯示轉換：將比較大的 int 放到小的 byte
            // 添加(資料類型)
            byte2 = (byte)int2;
            LogSysytem.LogWithColor(byte2, "#7f7");
            LogSysytem.LogWithColor(byte2.GetType(), "#7f7");

            // 浮點數轉為整數型別，小數點會遺失
            float float1 = 3.5f;
            byte byte3 = 0;

            byte3 = (byte)float1;
            LogSysytem.LogWithColor(byte3, "#f77");

            //範圍較大的轉為範圍要小的，會導致溢味
            int int3 = 256;
            byte byte4 = 0;
            byte4 = (byte)int3;
            LogSysytem.LogWithColor(byte4, "#f77");

            LogSysytem.LogWithColor("--------------", "#ff3");

        }

        private void Start()
        {
            // 將整數轉為字串
            int count = 99;
            var intToString = Convert.ToString(count);
            LogSysytem.LogWithColor(intToString.GetType(), "#f96");
            // 將布林值轉為字串
            bool isOver = false;
            var boolToString = Convert.ToString(isOver);
            LogSysytem.LogWithColor(boolToString.GetType(),"#f96");

            float move = 3.5f;
            var floatToByte = Convert.ToByte(move);
            LogSysytem.LogWithColor(floatToByte.GetType(), "#f96");

            // true = 1, flase = 0
            bool isGrounded = true;
            var boolToByte = Convert.ToByte(isGrounded);
            LogSysytem.LogWithColor(boolToByte, "#6f6");
            LogSysytem.LogWithColor(boolToByte.GetType(), "#6f6");
            

        }
    }

}