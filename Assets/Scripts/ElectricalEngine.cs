using UnityEngine;

public class ElectricalEngine : Engine
{
    public Battery Battery;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float energySpend = 1f;

    public float Speed => speed;
    public float EnergySpend => energySpend;
}
