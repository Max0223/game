using UnityEngine;

public class FactoryFirst : MonoBehaviour
{
    [SerializeField] private Transform _gasCar;
    [SerializeField] private Transform _gasEngine;

    private void Start()
    {
        var parent = Instantiate(_gasCar, new Vector2(-10, 1), Quaternion.identity);
        var child = Instantiate(_gasEngine, parent.transform.position, Quaternion.identity);
        child.SetParent(parent);

        parent.GetComponent<Car>().Construct(child.GetComponent<GasEngine>());
    }
}