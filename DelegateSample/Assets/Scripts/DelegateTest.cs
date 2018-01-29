using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    public delegate void Callback();
    private Callback _callback;

    public void SetCallback(Callback callback)
    {
        Debug.Log("SetCallback");
        callback();
    }

    public void AddCallback(Callback callback)
    {
        Debug.Log("AddCallback");
        this._callback += callback;
    }
}