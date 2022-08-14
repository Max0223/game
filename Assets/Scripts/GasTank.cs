using UnityEngine;

public class GasTank
{
    [SerializeField] private float _tank = 100f;

    public GasTank(float tank)
    {
        _tank = tank;
    }
    
    public float Tank => _tank;
    
    public float Spend(float cost) => _tank -= cost;
}