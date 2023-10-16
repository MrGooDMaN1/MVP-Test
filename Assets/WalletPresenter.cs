using System;
using UnityEngine;

public class WalletPresenter : Presenter
{

    //Методы активации и деактивации
    public WalletPresenter (Model model, View view) : base (model, view) { }

    public override void OnValueChanged(int value)
    {
        _view.OnValueChanged(value);
    }

    public override void OnValueChangingPercent(float percent)
    {
        _view.OnValueChangingPercent(percent);
    }
}
