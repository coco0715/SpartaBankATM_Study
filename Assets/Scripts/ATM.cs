using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ATM : MonoBehaviour
{
    public int cash = 100000;
    public int balance = 50000;
    public int count = 0;

    //[SerializeField] private GameObject btnCashInfo;
    //public TextMeshProUGUI txtCloseMark;
    [SerializeField] private GameObject uiPopup;
    [SerializeField] private TMP_InputField inputDeposit;
    [SerializeField] private TMP_Text textCashValue;
    [SerializeField] private TMP_Text textBalanceValue;

    private void UpdateMoney()
    {
        textCashValue.text = cash.ToString();
        textBalanceValue.text = balance.ToString();
    }
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
            UpdateMoney();
        }
        else
        {
            uiPopup.SetActive(true);
        }
    }

    public void InputCount(int amount)
    {
        if (amount <= cash)
        {
            count += 1;
        }
    }

    public void ClosePopup()
    {
        uiPopup.SetActive(false);
    }

    //TODO
    //public void CloseDepositCountInfo()
    //{
    //    txtCloseMark.text = "O";  
    //}
}
