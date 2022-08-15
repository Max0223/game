using UnityEngine;

public class Battery
{
    [SerializeField] private float _charge = 200f;

    public Battery(BatteryConfig batteryConfig) 
    {
        _charge = batteryConfig.charge;
    }

    public float Charge => _charge;
    
    public float Spend(float cost) => _charge -= cost;
}
