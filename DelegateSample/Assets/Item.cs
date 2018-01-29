using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//監視されるオブジェクトなど
public class Item : Observable
{
    /// <summary>
    /// ボタンを押したときに呼ぶ関数
    /// </summary>
    public void ClickButton()
    {
        SendNotification(Test);
    }

    void Test()
    {
        _mystery[0] = true;
        Debug.Log("ボタンが押されました");
    }

    /// <summary>
    /// 継承先からオーバーライドされた関数です
    /// イベントが起きたときにこの関数を呼ぶことで
    /// 監視者に通知を送ることができます
    /// </summary>
    /// <param name="func"></param>
    public override void SendNotification(Callback func)
    {
        base.SetCallback(func);
    }
}
