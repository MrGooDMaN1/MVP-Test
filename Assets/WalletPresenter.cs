using System;
using UnityEngine;

public class WalletPresenter : Presenter
{
    public WalletPresenter (Model model, View view) : base (model, view) { }

    public override void OnValueChanged(int value, float percent)
    {
        _view.OnValueChanged(value, percent);
    }
}
