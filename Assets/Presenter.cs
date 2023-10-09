using System;
using UnityEngine;

public abstract class Presenter : MonoBehaviour
{
    protected Model _model;
    protected View _view;

    public Presenter(Model model, View view)
    {
        this._model = model;
        this._view = view;
        model.ValueChanged += OnValueChanged;
    }

    public abstract void OnValueChanged(int value);
}
