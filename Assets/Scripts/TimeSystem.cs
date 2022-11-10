using System;       //DateTimeおよびTimeSpan構造体を使用するため
using UnityEngine;
public class TimeSystem : MonoBehaviour
{
    void Start()
    {
        //DateTime型の変数を宣言し特定の日時（2022年11月8日19:59:00）で初期化する
        DateTime specificDate = new DateTime(2022, 11, 8, 19, 59, 0);
        //DateTime型の変数を宣言し現在の日時で初期化する
        DateTime nowDate = DateTime.Now;
        //TimeSpan型の変数を宣言し現在日時と特定の日時の差で初期化する
        TimeSpan interval = nowDate - specificDate;
        //日時の差を秒数でコンソールに出力する
        Debug.Log(interval.TotalSeconds);
    }
}