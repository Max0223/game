using UnityEngine;

public abstract class Engine : MonoBehaviour
{
    public float Speed { get; set; }
    public float FuelSpend { get; set; }

    public void GetSpeed(float _speed)
    {
        Speed = _speed;
    }
    public void GetFuelSpend(float _fuelSpend)
    {
        FuelSpend = _fuelSpend;
    }
}
