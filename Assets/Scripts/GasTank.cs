using UnityEngine;

public class GasTank
{
    [SerializeField] private float _tank = 100f;

    public GasTank(GasTankConfig gasTankConfig) 
    {
        _tank = gasTankConfig.tank;
    }
    
    public float Tank => _tank;
    
    public float Spend(float cost) => _tank -= cost;
}