using UnityEngine.UI;

public class WalletViewSlider : View
{
    protected Slider _numberSlider;

    public WalletViewSlider(Slider numberSlider)
    {
        _numberSlider = numberSlider;
        _numberSlider.enabled = true;
    }

    public override void OnValueChanged(int value, float percent)
    {
        _numberSlider.value = percent;
        
    }
}
