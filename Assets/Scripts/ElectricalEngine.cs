using UnityEngine;

public class ElectricalEngine : Engine
{
    [SerializeField] private Battery _battery;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float energySpend = 1f;

    public override float Speed => speed;
    public override bool TryMove()
    {
        if (_battery.Charge > 0)
        {
            _battery.Spend(energySpend);
            return true;
        }
        return false;
    }
}
