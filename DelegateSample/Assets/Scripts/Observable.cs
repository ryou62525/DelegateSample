using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//監視される側に継承させるクラス
public class Observable : IObserver
{
    /// <summary>
    /// 通知を送る関数
    /// 謎解きが終了したときに通知を送るので
    /// 各謎ときを管理しているクラスに継承させてください
    /// </summary>
    /// <param name="func"></param>
    public virtual void SendNotification(Callback func)
    {
        SetCallback(func);
    }

}