using UnityEngine;

public class GasTank : MonoBehaviour
{
    [SerializeField] private float tank = 100f;

    public float Tank => tank;
    public float Spend(float cost) => tank -= cost;
}