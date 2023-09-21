using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyButten : MonoBehaviour
{
    public Text ScriptTxt;
    public Text myCashTxt;

    public static int Gold = 50000;
    public static int myCash = 100000;

    void Start()
    {
        ScriptTxt.text = Gold.ToString();
        myCashTxt.text = myCash.ToString();
    }
    public void one_GoldUp()
    {
        Gold += 10000;
        ScriptTxt.text = Gold.ToString();
        myCash -= 10000;
        myCashTxt.text = myCash.ToString();
    }

    public void three_GoldUp()
    {
        Gold += 30000;
        ScriptTxt.text = Gold.ToString();
        myCash -= 30000;
        myCashTxt.text = myCash.ToString();
    }

    public void five_GoldUp()
    {
        Gold += 50000;
        ScriptTxt.text = Gold.ToString();
        myCash -= 50000;
        myCashTxt.text = myCash.ToString();
    }

    public void one_GoldDown()
    {
        Gold -= 10000;
        ScriptTxt.text = Gold.ToString();
        myCash += 10000;
        myCashTxt.text = myCash.ToString();
    }
    public void three_GoldDown()
    {
        Gold -= 30000;
        ScriptTxt.text = Gold.ToString();
        myCash += 30000;
        myCashTxt.text = myCash.ToString();
    }
    public void five_GoldDown()
    {
        Gold -= 50000;
        ScriptTxt.text = Gold.ToString();
        myCash += 50000;
        myCashTxt.text = myCash.ToString();
    }

}
