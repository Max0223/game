using UnityEngine;

public class GasTank : MonoBehaviour
{
    [SerializeField] private float tank = 100f;

    public bool HasFuel() => tank > 0;

    public void Spend(float cost) => tank -= cost;
}