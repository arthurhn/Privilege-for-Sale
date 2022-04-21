using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingCart : MonoBehaviour
{
    public SlotLogic sl, sl1, sl2, sl3, sl4;
    public CardLogic c, c1, c2, c3, c4, c5, c6, c7, c8;
    private int total, subt;

    public void Start()
    {
        sl.SetSValue(0);
        sl1.SetSValue(0);
        sl2.SetSValue(0);
        sl3.SetSValue(0);
        sl4.SetSValue(0);
        c.SetCValue(850);
        c1.SetCValue(750);
        c2.SetCValue(650);
        c3.SetCValue(500);
        c4.SetCValue(300);
        c5.SetCValue(200);
        c6.SetCValue(200);
        c7.SetCValue(250);
        c8.SetCValue(200);
        subt = 1500;
    }
    public void SetTotal()
    {
        total = 0;
        total = sl.GetSValue() + sl1.GetSValue() + sl2.GetSValue() + sl3.GetSValue() + sl4.GetSValue();
    }

    public int GetTotal()
    {
        return total;
    }
    public void SetSub()
    {
        subt = 1500;
        subt = 1500 - total;
    }

    public int GetSub()
    {
        return subt;
    }
}
