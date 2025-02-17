using UnityEngine;

/// <summary>
/// 作業:陣列
/// </summary>
public class Practice_6_Array : MonoBehaviour 
{
    private string[,,] characterNames =
    {
        { {"小火龍", "火恐龍", "噴火龍"}, {"傑尼龜", "卡咪龜","水箭龜"} },
        { {"綠水靈", "藍水靈", "綠水靈王"}, {"肥肥", "緞帶肥肥","鋼鐵肥肥"} },
        { {"慎", "伊瑞莉雅", "賈克斯"}, {"艾希", "凱特琳","希維爾"} }
    };

    private void Awake()
    {
        Debug.Log($"<color=#f6a>小火龍:{characterNames[0, 0, 0]}</color>");
        Debug.Log($"<color=#f6a>綠水靈:{characterNames[1, 0, 2]}</color>");
        Debug.Log($"<color=#f6a>慎:{characterNames[2, 1, 1]}</color>");

        Debug.Log($"<color=#f6a>第二頁第一排第三個:{characterNames[1, 0, 2]}</color>");
    }
}