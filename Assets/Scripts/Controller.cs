using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private bool _clickCheck = false;
    [SerializeField] private Factory _gasCarFactory;
    [SerializeField] private Factory _electricalCarFactory;
    private Car _gasCar;
    private Car _electricalCar;
    private int count;

    private void Awake()
    {
        _gasCar = _gasCarFactory.Create();
        _electricalCar = _electricalCarFactory.Create();
        Car.HasFuel += EndGameWindow;
    }

    private void Update()
    {
        if (_clickCheck == false && Input.GetKeyUp(KeyCode.Space))
        {
            _clickCheck = true;
            StartCoroutine(_gasCar.Moving());
            StartCoroutine(_electricalCar.Moving());
        }
    }

    private void EndGameWindow()
    {
        count++;
        if (count >= 2)
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
