using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public DelegateTest _delegateTest;

    public void ClickAttack()
    {
        _delegateTest.SetCallback(Attack);
    }

    public void ClickDefence()
    {
        _delegateTest.SetCallback(Defence);
    }
    
    public void ClickItem()
    {
        _delegateTest.SetCallback(Item);
    }

    private void Attack()
    {
        Debug.Log("Attack");
    }

    private void Defence()
    {
        Debug.Log("Defence");
    }

    private void Item()
    {
        Debug.Log("Item");
    }
}