using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalletModel : Model
{
    public override void AddValue(int amount)
    {
        value += amount;
        base.AddValue(amount);
    }

    public override void SubtractValue(int amount)
    {
        if ((value - amount) < 0)
            Debug.Log("Error. There are not enough coins in the wallet");
        else
            value -= amount;

        base.SubtractValue(amount);
    }
}
