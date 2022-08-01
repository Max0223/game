using UnityEngine;

public class GasEngine : Engine
{
    [SerializeField] private GasTank _gasTank;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float fuelSpend = 2f;

    public override float Speed => speed;
    public override bool TryMove()
    {
        if (_gasTank.Tank > 0)
        {
            _gasTank.Spend(fuelSpend);
            return true;
        }
        return false;
    }
}
