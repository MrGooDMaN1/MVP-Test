using UnityEngine;
using UnityEngine.UI;

public abstract class View : MonoBehaviour
{
    protected Model _model;
    protected Text _numberText;
    protected Slider _numberSlider;

    public View(Model model, Text numberText, Slider numberSlider)
    {
        this._model = model;
        this._numberText = numberText;
        this._numberSlider = numberSlider;
    }

    public virtual void OnValueChanged(int value) { }
    public virtual void OnValueChangingPercent(float percent) { }
}
