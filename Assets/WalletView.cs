using UnityEngine;
using UnityEngine.UI;

public class WalletView : View
{
    public WalletView(Model model, Text numberText) : base(model, numberText) { }
    public override void OnValueChanged(int value)
    {
        _numberText.text = value.ToString();
        base.OnValueChanged(value);
    }
}
