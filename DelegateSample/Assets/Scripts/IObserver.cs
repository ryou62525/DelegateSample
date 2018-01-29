using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ゲーム全体を監視するクラス
public class IObserver : MonoBehaviour
{
    public delegate void Callback();

    [HideInInspector] public List<bool> _mystery = new List<bool>();

    void OnEnable()
    {
        for (int i = 0; i < 4; i++)
        {
            _mystery.Add(false);
        }

        Debug.Log("開始されました");
        foreach (var mystery in _mystery)
        {
            Debug.Log(mystery);
        }
    }

    /// <summary>
    /// 通知された関数を実行する
    /// </summary>
    /// <param name="callback"></param>
    public void SetCallback(Callback callback)
    {
        callback();
        Debug.Log("通知されました");
        foreach (var mystery in _mystery)
        {
            Debug.Log(mystery);
        }    
    }
}