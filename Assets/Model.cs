using System;
using UnityEngine;

public abstract class Model : MonoBehaviour
{
    public event Action<int> ValueChanged;
    public event Action<float> ValueChangingPercent;

    protected int _value = 0;
    protected float _percent = 0;
    protected float _maxBalance = 300f;

    public int GetValue()
    {
        return _value;
    }

    public virtual void AddValue(int amount)
    {
        ValueChanged?.Invoke(_value);
        ValueChangingPercent?.Invoke(_percent);
    }
    public virtual void SubtractValue(int amount)
    {
        ValueChanged?.Invoke(_value);
        ValueChangingPercent?.Invoke(_percent);
    }
}
