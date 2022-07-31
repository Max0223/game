using UnityEngine;

public class GasEngine : Engine
{
    [SerializeField] private GasTank GasTank;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float fuelSpend = 2f;

    public override float GetSpeed => speed;
    public override float Spend() => GasTank.Spend(fuelSpend);
    public override bool TryMove() => GasTank.Tank > 0;
}
