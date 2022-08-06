using UnityEngine;

public class Battery
{
    [SerializeField] private float _charge = 200f;

    public float Charge => _charge;
    
    public float Spend(float cost) => _charge -= cost;
}
