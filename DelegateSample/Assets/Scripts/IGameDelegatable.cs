using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGameDelegatable : MonoBehaviour
{
    public delegate void Callback();
    
    public void SendNotification(Callback callback)
    {
        callback();
    }
}