using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //인풋 필드 쓰려면 필요하다고함.

public class Money : MonoBehaviour
{
    [SerializeField] private Text txt_money;
    [SerializeField] private InputField inputTxT_Money;
    //[SerializeField] private Text txt_cash;
    //[SerializeField] private InputField inputTxT_Cash;

    private int current_Money;

    public void Start()
    {
        MoneyButten.Gold = int.Parse(txt_money.text);
        //MoneyButten.Gold = int.Parse(txt_cash.text);//텍스트에 입력되어있는 값으로 현재 돈 초기화하는 코드.

    }
    public void Input() //입금
    {
        MoneyButten.Gold += int.Parse(inputTxT_Money.text);
        //MoneyButten.Gold -= int.Parse(inputTxT_Cash.text);//입력받은 문자형 숫자를 int형 숫자로 바꿔주는 코드

        txt_money.text = MoneyButten.Gold.ToString();
        //txt_cash.text = MoneyButten.Gold.ToString();//int타입을 string 타입으로 바꾸어 화면에 반하는 코드.
    }

    public void Output() //출금
    {

        MoneyButten.Gold -= int.Parse(inputTxT_Money.text);
        //MoneyButten.Gold += int.Parse(inputTxT_Cash.text);//문자형 숫자를 int형 숫자로 바꿔주는 코드.

        txt_money.text = MoneyButten.Gold.ToString();
        //txt_cash.text = MoneyButten.Gold.ToString();//int타입을 string 타입으로 바꿔주는 코드.
    }
}
