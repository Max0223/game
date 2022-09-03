using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    [Header("Factories")]
    [SerializeField] private Factory _gasCarFactory;
    [SerializeField] private Factory _electricalCarFactory;
    private Car _gasCar;
    private Car _electricalCar;
    private bool _clickCheck = false;
    private int _count;

    private void Awake()
    {
        _gasCar = _gasCarFactory.Create();
        _electricalCar = _electricalCarFactory.Create();
    }

    private void OnEnable()
    {
        _gasCar.EnergyEmptied += OnEnergyEmptied;
        _electricalCar.EnergyEmptied += OnEnergyEmptied;
        _uiManager.PlayButtonClicked += OnClick;
    }

    public void OnClick()
    {
        if (_clickCheck == false)
        {
            _clickCheck = true;
            StartCoroutine(_gasCar.Moving());
            StartCoroutine(_electricalCar.Moving());
        }
    }

    private void OnEnergyEmptied()
    {
        _count++;
        if (_count >= 2)
        {
            _uiManager.ShowGameEndScreen();
        }
    }
}
