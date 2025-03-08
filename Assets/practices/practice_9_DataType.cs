using KAI.Tools;
using UnityEngine;

namespace KAI
{
    /// <summary>
    /// 資料類型轉換
    /// </summary>
    public class practice_9_DataType : MonoBehaviour
    {
        private void Awake()
        {
            float number = -999.321f;
            sbyte byteNumber = (sbyte)number;
            LogSysytem.LogWithColor(byteNumber, "#f77");
        }
    } 
}
