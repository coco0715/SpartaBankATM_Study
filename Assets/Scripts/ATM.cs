using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATM : MonoBehaviour
{
    public int cash = 100000;
    public int balance = 50000;
    public int count = 0;
    public bool depositCheck = false;
   
    public void Deposit(int amount)
    {
        if (amount <= cash)
        {
            cash -= amount;
            balance += amount;
        }
    }

    public void InputCount(bool depositCheck)
    {
        if (depositCheck)
        {
            count += 1;
            depositCheck = false;
        }
    }
}
