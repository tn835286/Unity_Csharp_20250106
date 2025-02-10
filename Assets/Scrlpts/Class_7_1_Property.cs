using UnityEngine;

namespace KID
{
    /// <summary>
    /// 屬性 Property
    /// </summary>
    public class Class_7_1_Property : MonoBehaviour
    {
        //公開的變數:可以讓外部讀取與寫入
        public float moveSpeed = 3.5f;

        //死人的變數:不允許外部讀取與寫入
        private float turnSpeed = 12.7f;
    }
}
