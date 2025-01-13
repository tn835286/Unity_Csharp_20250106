﻿using UnityEngine;

/// <summary>
/// 課程 3 :運算子
/// 補充 : Unity 欄位屬性、Unity 事件
/// </summary>
public class Class_3_Operator : MonoBehaviour 
{
    #region 基本的欄位屬性
    // C#  變數 = 欄位 Field
    // 欄位屬性 Field Attritube
    // [標題(標題文字)] : 在屬性面板上顯示標題文字
    [Header("等級")]
    public int lv = 1;
    // [提示(提示文字)] : 在屬性面板滑鼠停留在變數上時顯示
    [Tooltip("這是角色的移動速度，不建議超過 100。")]
    public float moveSpeed = 2.5f;
    // [範圍(最大、最小)] : 幫數值類型添加範圍 (面板上改為滑桿)
    [Range(1, 100)]
    public byte count = 10;
    // 範圍不能使用在非數值類型上，會顯示 "Use Range With..."
    [Range(0, 10)]
    public string weapon = "匕首";
    // [文字範圍(最小行，最大行)] : 使用在字串上，設定面板上的文字框範圍
    [TextArea(2, 5)]
    public string itemDescription = "這裡是道具的描述，這裡是道具的描述，這裡是道具的描述。";
    // 多個欄位屬性
    [Header("血量")][Range(0, 999)]
    public int hp = 100;
    [Header("攻擊力"), Range(0, 100)]
    public float attack = 30.5f;
    // [在屬性面板隱藏] : 將公開變數隱藏
    [HideInInspector]
    public string password = "我是密碼";
    // [序列畫欄位] : 將私人變數顯示
    [SerializeField]
    private float mp = 500;
    #endregion

    // 使用 Unity 的事件
    // 1. 必須在腳本後面添加 : MoniBehaviour (繼承)
    // 2. 使用關鍵字快速完成，例如 : 輸入 Awake 挑選要使用的是件按 Enter
    // 喚醒事件 : 播放遊戲後會執行的第一個事件，只執行一次
    // 事件名稱是藍色的 (沒有變色不影響)
    private void Awake()
    {
        #region 輸出訊息
        // 將小括號內的訊息輸出到 Unity 的 Console 控制台面板
        // Ctrl+ shift + C 開啟控制台面板
        Debug.Log("哈囉，沃德 :D");          // 輸出文字
        Debug.Log(hp);                      // 輸出變數的值
        Debug.Log("攻擊力 :" + attack);      // 字串的變數
        Debug.Log($"攻擊力 : {attack}");     // $字串格式
        Debug.Log("攻擊力 : {attack}");      // 沒有寫$

        Debug.Log("<b>粗體</b>");
        Debug.Log("<color=orange>橘色</color>");
        Debug.Log("<color=#66aaff>藍色</color>");
        Debug.Log("<color=#6af>藍色</color>");
        #endregion



        #region 算術運算子
        Debug.Log("<color=#f93>--- 算術運算子 ---</color>");
        // 運算子 :
        // 1. 算術運算子
        // 加、減、乘、除、餘
        // +、-、*、/、%
        Debug.Log(10 + 3);      // 13
        Debug.Log(10 - 3);      //7
        Debug.Log(10 * 3);      // 30
        Debug.Log(10 / 3);      // 3
        Debug.Log(10 % 3);      // 10 / 3 - 3 餘 1，結果 1

        Debug.Log("<color=#f93>--- 算術運算子 : 區域變數 ---</color>");
        // 區域變數 : 僅在此大括號內存取 (不需要修飾詞的變數)
        float numberA = 10;
        float numberB = 3;

        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB);       // 3.333
        Debug.Log(numberA % numberB);
        #endregion

        Debug.Log("<color=#f93>--- 比較運算子 ---</color>");
        // 比較運算子，使用後會得到布林值
        int numberC = 100, numberD = 1;

        Debug.Log(numberC > numberD);       // 大    於 True
        Debug.Log(numberC < numberD);       // 小    於 False
        Debug.Log(numberC >= numberD);      // 大於等於 True
        Debug.Log(numberC <= numberD);      // 小於等於 False
        Debug.Log(numberC == numberD);      // 等    於 False
        Debug.Log(numberC != numberD);      // 不  等於 True
    }
}
