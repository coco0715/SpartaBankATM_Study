using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ATM : MonoBehaviour
{
    public int cash = 100000;
    public int balance = 50000;
    public int count = 0;

    [SerializeField]private TMP_InputField inputDeposit;
   

    public void InputDepositMoney()
    {
        int amount;
        int.TryParse(inputDeposit.text, out amount);
        Deposit(amount);
    }
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
