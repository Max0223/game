using System;
using System.Collections;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Engine _engine;
    private Transform _transform;
    
    public event Action EnergyEmptied;

    public void Construct(Engine engine) => _engine = engine;
    
    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    public IEnumerator Moving()
    {
        while (_engine.TryMove())
        {
            _transform.Translate(_engine.Speed * Time.deltaTime, 0, 0);
            yield return new WaitForFixedUpdate();
        }
        EnergyEmptied?.Invoke();
    }
}
