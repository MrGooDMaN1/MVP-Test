using Newtonsoft.Json.Linq;
using System;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Model : MonoBehaviour
{
    public event Action<int> ValueChanged;

    protected int value = 0;

    public int GetValue()
    {
        return value;
    }

    public virtual void AddValue(int amount)
    {
        ValueChanged?.Invoke(value);
    }
    public virtual void SubtractValue(int amount)
    {
        ValueChanged?.Invoke(value);
    }
}
