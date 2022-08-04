using UnityEngine;

public class FactorySecond : MonoBehaviour
{
    [SerializeField] private Transform _electricalCar;
    [SerializeField] private Transform _electricalEngine;

    private void Start()
    {
        var parent = Instantiate(_electricalCar, new Vector2(-10, -1), Quaternion.identity);
        var child = Instantiate(_electricalEngine, parent.transform.position, Quaternion.identity);
        child.SetParent(parent);

        parent.GetComponent<Car>().Construct(child.GetComponent<ElectricalEngine>());
    }
}