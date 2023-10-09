using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private ViewType _viewType;
    [SerializeField] private Slider _numberSlider;
    [SerializeField] private Text _numberText;
    private int _currentValue = 0;

    public Button _addButton;
    public Button _subtractButton;

    private void Start()
    {
        Model walletModel = new WalletModel();
        View walletView = new WalletView(walletModel, _numberText);
        Presenter walletPresenter = new WalletPresenter(walletModel, walletView);

        if (_viewType == ViewType.Number)
        {
            // Привязываем обработчики кнопок
        }
        _addButton.onClick.AddListener(() => walletModel.AddValue(15));
        _subtractButton.onClick.AddListener(() => walletModel.SubtractValue(6));
    }

    private enum ViewType
    {
        Number,
        Slider
    }
}
