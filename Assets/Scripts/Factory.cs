using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] private Car _car;
    [SerializeField] private Engine _engine;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        var car = Instantiate(_car, _spawnPoint.position, Quaternion.identity);
        var engine = Instantiate(_engine, car.transform.position, Quaternion.identity, car.transform);

        car.Construct(engine);
    }
}