using UnityEngine;

public class GasEngine : Engine
{
    [SerializeField] private GasTank _gasTank;
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _fuelSpend = 2f;

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
