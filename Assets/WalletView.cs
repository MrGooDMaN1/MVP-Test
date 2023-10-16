using UnityEngine.UI;

public class WalletView : View
{
    protected Text _numberText;

    public WalletView(Text numberText)
    {
        _numberText = numberText;
        _numberText.enabled = true;
    }

    public override void OnValueChanged(int value, float percent)
    {
        _numberText.text = value.ToString();
    }
}
