using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //��ǲ �ʵ� ������ �ʿ��ϴٰ���.

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
        //MoneyButten.Gold = int.Parse(txt_cash.text);//�ؽ�Ʈ�� �ԷµǾ��ִ� ������ ���� �� �ʱ�ȭ�ϴ� �ڵ�.

    }
    public void Input() //�Ա�
    {
        MoneyButten.Gold += int.Parse(inputTxT_Money.text);
        //MoneyButten.Gold -= int.Parse(inputTxT_Cash.text);//�Է¹��� ������ ���ڸ� int�� ���ڷ� �ٲ��ִ� �ڵ�

        txt_money.text = MoneyButten.Gold.ToString();
        //txt_cash.text = MoneyButten.Gold.ToString();//intŸ���� string Ÿ������ �ٲپ� ȭ�鿡 ���ϴ� �ڵ�.
    }

    public void Output() //���
    {

        MoneyButten.Gold -= int.Parse(inputTxT_Money.text);
        //MoneyButten.Gold += int.Parse(inputTxT_Cash.text);//������ ���ڸ� int�� ���ڷ� �ٲ��ִ� �ڵ�.

        txt_money.text = MoneyButten.Gold.ToString();
        //txt_cash.text = MoneyButten.Gold.ToString();//intŸ���� string Ÿ������ �ٲ��ִ� �ڵ�.
    }
}
