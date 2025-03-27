using System;
using KAI.Tools;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace KAI.Class_19
{
    /// <summary>
    /// 委派
    /// </summary>
    public class Class_19_1_Delegate : MonoBehaviour
    {
        #region 複習可當參數的變數與元組
        private void Awake()
        {
            Cure(10);
            Card(("史萊姆", 7));
        }

        //將 float 當作參數
        private void Cure(float cure)
        {
            LogSysytem.LogWithColor($"治癒的值:{cure}", "#3f3");
        }

        //將 元組 當作參數
        private void Card((string name, int index) card)
        {
            LogSysytem.LogWithColor($"卡片:{card.name}|{card.index}", "#3f3");
        } 
        #endregion

        // 1. 宣告委派 : 簽章 (傳回與參數)
        // 宣告一個無傳回與吳參數的委派
        private delegate void DelegateMethod();
        private delegate float Calculate(float numberA, float numberB);
        private delegate void DelegateCombine<T>(T a);

        // 2. 目標方法 : 簽章必須與委派相同
        #region 無傳回與無參數方法
        private void Test()
        {
            LogSysytem.LogWithColor("測試", "#f3f");
        }

        private void Talk()
        {
            LogSysytem.LogWithColor("哈囉", "#f39");
        }

        private void MagicCard()
        {
            LogSysytem.LogWithColor("召喚小兵", "#3f3");
        }
        #endregion
        private float Add(float numberA, float numberB)
        {
            float result = numberA + numberB;
            LogSysytem.LogWithColor(result, "#7ff");
            return numberA + numberB;
        }

        private float Sub(float numberA, float numberB)
        {
            float result = numberA - numberB;
            LogSysytem.LogWithColor(result, "#7ff");
            return numberA - numberB;
        }

        private float Mul(float numberA, float numberB)
        {
            float result = numberA * numberB;
            LogSysytem.LogWithColor(result, "#7ff");
            return numberA - numberB;
        }

        private void Combine<T>(T a)
        {
            LogSysytem.LogWithColor(a, "#ff3");
        }

        // 3. 宣告變數存放方法(預設空值)
        private DelegateMethod delegateMethod;
        private Calculate calculate;
        private DelegateCombine<float> delegateCombineFloat;
        private DelegateCombine<int> delegateCombineInt;
    
        // func
        // 可以存放有傳回並且有 0 個參數以上的方法
        // 宣告一個委派，有一個參數 float，並且傳回值 float
        // <參數，傳回值>
        private Func<float, float> funcCalc;

        // Action
        // 可以存放無傳回並且有 0 個參數以上的方法
        // 宣告一個委派，沒有參數也沒有傳回值
        private Action actionMethod;
        
        // Predicate
        // 可以存放有布林值傳回並且有 1 個參數的方法
        // 宣告一個委派，有一個參數 float，並且傳回值有 bool
        private Predicate<float> predicate; 
        
        // 4. 呼叫委派
        private void Start()
        {
            #region 基本委派
            delegateMethod = Test;          //將方法 Test 存放到變數 delegateMethod 內
            delegateMethod += Talk;         // 多播委派 : 一個委派存放多個方法，相同簽章
            delegateMethod += MagicCard;    // 可添加多個方法 
            delegateMethod -= Test;         // 也可刪除方法

            delegateMethod();           // 呼叫委派 
            #endregion

            #region 多播委派及泛型委派
            calculate += Add;
            calculate += Sub;
            calculate += Mul;
            calculate(10, 3);
            calculate(50, 80);
            CalcuteNumber(Sub, 3, 7);       //將方法當作參數傳遞
            delegateCombineFloat = Combine<float>;
            delegateCombineFloat(3.5f);
            delegateCombineInt = Combine<int>;
            delegateCombineInt(999);
            #endregion

            #region 匿名方法
            // 匿名方法
            //delegate (參數) {陳述式}
            DelegateMethod anonymousMethod = delegate () { };
            Calculate anonymousCalc = delegate (float a, float b) { return a * b; };
            // 簡寫方式
            DelegateMethod anonymousDelegateMethod2 = () => { };
            Calculate anonymousCalc2 = (a, b) => { return a * b; };


            CalcuteNumber(Add, 3, 7);
            CalcuteNumber(anonymousCalc, 3, 7);
            CalcuteNumber(anonymousCalc2, 3, 7);

            // 在參數上面使用匿名方法
            CalcuteNumber(delegate (float a, float b) { return a / b; }, 9, 3);
            CalcuteNumber((a, b) => { return a / b; }, 9, 3); 
            #endregion

            funcCalc = delegate(float x) { return x* 10; };
            LogSysytem.LogWithColor($"Func 委派 :{funcCalc(3.5f)}", "#f33");

            actionMethod = delegate() { LogSysytem.LogWithColor("Action 委派", "#f33"); };
            actionMethod();

            predicate = delegate (float x) { return x > 0; };
            LogSysytem.LogWithColor($"Predicate 委派: 7 是否大於零 - {predicate(7)}", "#f33");

            // Lambda 運算子 =>
            // (參數) => {陳述式}
            Action action = () => { LogSysytem.LogWithColor("Lambda 練習", "#ff3"); };
            action();

            Func<int, string>func = (x) => {  return $"Lambda 練習，數字:{x}"; };
            LogSysytem.LogWithColor($"{func(77)}", "#ff3");

            Predicate<string> predicateTest = (x) => { return x.Length > 0; };
            LogSysytem.LogWithColor($"{predicateTest("KAI")}", "#ff3");
          
        }

        // 委派 : 將 方法 當作參數
        private void CalcuteNumber(Calculate calculate, float a, float b)
        {
            var result = calculate(a, b);
            LogSysytem.LogWithColor(result, "#ff3");
        }
    }
    
}
