using UnityEngine;

public class GasTank : MonoBehaviour
{
    private float tank = 700f;

    public bool HasFuel() => tank > 0;

    public void Spend(float cost) => tank -= cost;
}