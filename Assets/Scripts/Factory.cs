using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] private Car _car;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Cars _cars;
    [Header("Configs")]
    [SerializeField] private GasEngineConfig _gasEngineConfig;
    [SerializeField] private ElectricalEngineConfig _electricalEngineConfig;
    [SerializeField] private GasTankConfig _gasTankConfig;
    [SerializeField] private BatteryConfig _batteryConfig;

    private void Awake()
    {    
        var car = Instantiate(_car, _spawnPoint.position, Quaternion.identity);

        if (_cars == Cars.GasCar)
        {
            var gasTank = new GasTank(_gasTankConfig);
            Engine gasEngine = new GasEngine(gasTank, _gasEngineConfig);
            car.Construct(gasEngine);
        }
        else if (_cars == Cars.ElectricalCar)
        {
            var battery = new Battery(_batteryConfig);
            Engine electricalEngine = new ElectricalEngine(battery, _electricalEngineConfig);
            car.Construct(electricalEngine);
        }
    }
}