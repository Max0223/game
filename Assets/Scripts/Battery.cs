using UnityEngine;

public class Battery : MonoBehaviour
{
    [SerializeField] private float charge = 200f;

    public bool HasEnergy() => charge > 0;

    public void Spend(float cost) => charge -= cost;
}
