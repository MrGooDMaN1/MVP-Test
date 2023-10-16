using System;
using UnityEngine;

public abstract class Presenter
{
    protected Model _model;
    protected View _view;

    public Presenter(Model model, View view)
    {
        _model = model;
        _view = view;
        model.ValueChanged += OnValueChanged;
    }

    public abstract void OnValueChanged(int value, float percent);

}
