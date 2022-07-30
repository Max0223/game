using UnityEngine;

public class GasEngine : Engine
{
    public GasTank GasTank;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float fuelSpend = 2f;

    private void Update()
    {
        GetSpeed(speed);
        GetFuelSpend(fuelSpend);
    }

}
