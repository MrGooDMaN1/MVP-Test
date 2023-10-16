using System;

public abstract class Model
{
    public event Action<int, float> ValueChanged;

    private int _value = 0;
    private float _percent = 0;
    private float _maxBalance = 300f;

    public int Value 
    {
        get
        {
            return _value;
        }
        protected set
        {
            _value = value;
            _percent = _value / _maxBalance;
            ValueChanged?.Invoke(_value, _percent);
        }
    }

    public float MaxBalance { get { return _maxBalance; } }

    public abstract void ChangeValue(int amount);
}
