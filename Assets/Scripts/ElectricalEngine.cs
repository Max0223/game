using UnityEngine;

public class ElectricalEngine : Engine
{
    [SerializeField] private Battery _battery;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _energySpend = 1f;

    public override float Speed => _speed;
    
    public override bool TryMove()
    {
        if (_battery.Charge > 0)
        {
            _battery.Spend(_energySpend);
            return true;
        }
        return false;
    }
}
