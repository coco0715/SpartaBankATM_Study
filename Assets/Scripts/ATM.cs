using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATM : MonoBehaviour
{
    public int cash = 100000;
    public int balance = 50000;
    public int count = 0;
   
    public void Deposit(int amount)
    {
        if (amount <= cash)
        {
            cash -= amount;
            balance += amount;
        }
    }

    public void InputCount(int amount)
    {
        if (amount <= cash)
        {
            count += 1;
        }
    }
}
