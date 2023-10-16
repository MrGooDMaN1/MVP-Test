using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private ViewType _viewType;
    [SerializeField] private Slider _slider;
    [SerializeField] private Text _text;

    [SerializeField] private Button _addButton;
    [SerializeField] private Button _subtractButton;

    private void Start()
    {
        Model model = new WalletModel();

        View view;
        _slider.gameObject.SetActive(false);
        _text.enabled = false;
        switch (_viewType)
        {
            case ViewType.Slider:
                {
                    _slider.gameObject.SetActive(true);
                    view = new WalletViewSlider(_slider);
                    break;
                }
            default:
                {
                    _text.enabled = true;
                    view = new WalletView(_text);
                    break;
                }
        }

        Presenter walletPresenter = new WalletPresenter(model, view);

        _addButton.onClick.AddListener(() => model.ChangeValue(15));
        _subtractButton.onClick.AddListener(() => model.ChangeValue(-6));
    }

    private enum ViewType
    {
        Number,
        Slider
    }
}
