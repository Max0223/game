using UnityEngine;

public class Battery : MonoBehaviour
{
    [SerializeField] private float charge = 200f;

    public float Charge => charge;
    public float Spend(float cost) => charge -= cost;
}
