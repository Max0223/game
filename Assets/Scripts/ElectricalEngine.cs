using UnityEngine;

public class ElectricalEngine : Engine
{
    [SerializeField] private Battery Battery;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float energySpend = 1f;

    public override float GetSpeed => speed;
    public override float Spend() => Battery.Spend(energySpend);
    public override bool TryMove() => Battery.Charge > 0;
}
