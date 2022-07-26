using UnityEngine;

public class Battery : MonoBehaviour
{
    private float charge = 1000f;

    public bool HasEnergy() => charge > 0;

    public void Spend(float cost) => charge -= cost;
}
