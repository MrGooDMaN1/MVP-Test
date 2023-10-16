using System;
using UnityEngine;

public class WalletModel : Model
{
    public override void AddValue(int amount)
    {
        if ((_value + amount) >= 300)
            Debug.Log("Error. There are too many coins in the wallet");
        else
            _value += amount;

        _percent = _value / _maxBalance;

        base.AddValue(amount);
    }

    public override void SubtractValue(int amount)
    {
        if ((_value - amount) < 0)
            Debug.Log("Error. There are not enough coins in the wallet");
        else
            _value -= amount;

        _percent = _value / _maxBalance;

        base.SubtractValue(amount);
    }

    /*
    public void UpdateSliderValue()
    {
        float maxBalance = 1000f; // Максимальный баланс (примерное значение)
        float percentage = value / maxBalance; // Рассчитываем процент заполненности кошелька
        walletSlider.value = percentage * walletSlider.maxValue; // Устанавливаем значение слайдера
    }
    */
}
