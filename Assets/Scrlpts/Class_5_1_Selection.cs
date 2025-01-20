using System.Runtime.CompilerServices;
using UnityEngine;

// 命名空間 :
// 將類別分類，類似倉庫的概念。不同倉庫可以有相同名稱類別。
// 語法 : namespace 命名空間名稱 { 內容 }
namespace KID
{
    ///<summary>
    /// 選取陳述式 Selection Statement
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class Class_5_1_Selection : MonoBehaviour
    {
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;

        #region 判斷式
        private void Awake()
        {
            // if 判斷式
            // if (布林值) {陳述式}
            if (true)
            {
                Debug.Log("當布林值為True，會執行這裡。");
            }

            // 快速完成 : 輸入 if 選取 if 陳述式按 Enter 或 Tab
            if (false)
            {
                Debug.Log("當布林值為False，不會執行這裡而且會有綠蚯蚓。");
            }
        }
        #endregion

        // 更新事件 : 一秒鐘執行約 60 次 (60 FPS) Frame Per Second
        private void Update()
        {
            Debug.Log("<color=#79f>更新事件</color>");

            // 如果 isOpen 布林值等於 True，就顯示已經開門
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");
            }
            // 如果 isOpen 布林值等於 False，就顯示門關了
            else
            {
                Debug.Log("<color=#f93>門關了</color>");
            }

            // 比較運算子、邏輯運算子結果為布林值
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜你的 C# 課程過了</color>");
            }
            else
            {
                Debug.Log("<color=#3f3>恭喜你的 C# 課程被當了</color>");
            }
        }
    }
}
