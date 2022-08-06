using UnityEngine;

public class GasEngine : Engine
{
    private float _speed = 10f;
    private float _fuelSpend = 2f;
    private GasTank _gasTank = new GasTank();

    public override float Speed => _speed;
    
    public override bool TryMove()
    {
        if (_gasTank.Tank > 0)
        {
            _gasTank.Spend(_fuelSpend);
            return true;
        }
        return false;
    }
}
