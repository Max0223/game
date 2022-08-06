using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] private Car _car;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        GasEngine gasEngine = new GasEngine();
        ElectricalEngine electricalEngine = new ElectricalEngine();
        
        var car = Instantiate(_car, _spawnPoint.position, Quaternion.identity);

        car.Construct(gasEngine);
        car.Construct(electricalEngine);
    }
}