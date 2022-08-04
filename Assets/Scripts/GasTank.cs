using UnityEngine;

public class GasTank : MonoBehaviour
{
    [SerializeField] private float _tank = 100f;

    public float Tank => _tank;
    
    public float Spend(float cost) => _tank -= cost;
}