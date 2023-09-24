using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ATM : MonoBehaviour
{
    public int cash = 100000;
    public int balance = 50000;
    public int count = 0;
    //public bool cashInfoMark = true;

    //[SerializeField] private GameObject txtCloseMark;
    [SerializeField] private GameObject uiPopup;
    [SerializeField] private TMP_InputField inputDeposit;
    [SerializeField] private TMP_InputField inputWithdrawal;

    [SerializeField] private TMP_Text textCashValue;
    [SerializeField] private TMP_Text textBalanceValue;
    [SerializeField] private TMP_Text textDepositCount;

    public void UpdateMoney()
    {
        textBalanceValue.text = balance.ToString();
        textCashValue.text = cash.ToString();
        textDepositCount.text = count.ToString();
    }
    public void InputDepositMoney()
    {
        int amount;
        int.TryParse(inputDeposit.text, out amount);
        Deposit(amount);
    }
    public void InputWithdrawalMoney()
    {
        int amount;
        int.TryParse(inputWithdrawal.text, out amount);
        Withdrawal(amount);
    }
    public void Deposit(int amount)
    {
        if (amount <= cash)
        {
            cash -= amount;
            balance += amount;
            count++;
            UpdateMoney();
        }
        else
        {
            uiPopup.SetActive(true);
        }
    }

    public void Withdrawal(int amount)
    {
        if (amount <= balance)
        {
            cash += amount;
            balance -= amount;
            //count++;
            UpdateMoney();
        }
        else
        {
            uiPopup.SetActive(true);
        }
    }

    public void ClosePopup()
    {
        uiPopup.SetActive(false);
    }
    
    //public void CachInfoControllerMark()
    //{
    //    if (cashInfoMark)
    //    {
    //        txtCloseMark.SetActive(false);
    //        cashInfoMark = false;
    //    }
    //    else
    //    {
    //        txtCloseMark.SetActive(true);
    //        cashInfoMark = true;
    //    }
    //}
}
