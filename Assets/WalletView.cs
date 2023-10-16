using System;
using UnityEngine.UI;

public class WalletView : View
{
    public WalletView(Model model, Text numberText, Slider numberSlider) : base(model, numberText, numberSlider) { }
    public override void OnValueChanged(int value)
    {
        _numberText.text = value.ToString();
        base.OnValueChanged(value);
    }
    public override void OnValueChangingPercent(float percent)
    {
        _numberSlider.value = percent * _numberSlider.maxValue;
        base.OnValueChangingPercent(percent);
    }
}
