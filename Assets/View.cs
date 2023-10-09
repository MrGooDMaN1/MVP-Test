using UnityEngine;
using UnityEngine.UI;

public abstract class View : MonoBehaviour
{
    protected Model _model;

    //¬ конструкторе принимаютьс€ все пол€ класса
    protected Text _numberText;

    public View(Model model, Text numberText)
    {
        this._model = model;
        this._numberText = numberText;
    }

    public virtual void OnValueChanged(int value) { }
}
