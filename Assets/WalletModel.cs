using System;
using UnityEngine;

public class WalletModel : Model
{
    public override void ChangeValue(int amount)
    {
        if ((Value + amount) > MaxBalance)
        {
            Debug.Log("Error. There are too many coins in the wallet");
            return;
        }

        if ((Value + amount) < 0)
        {
            Debug.Log("Error. There are not enough coins in the wallet");
            return;
        }

        Value += amount;
    }
}
