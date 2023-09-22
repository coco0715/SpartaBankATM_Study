using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATM : MonoBehaviour
{
    public int cash = 100000;
    public int balance = 50000;
   
    public void Deposit(int amount)
    {
        if (amount <= cash)
        {
            cash -= amount;
            balance += amount;
        }
    }
}
