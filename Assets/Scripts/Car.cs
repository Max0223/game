using System.Collections;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Engine _engine;
    private bool _clickCheck = false;
    private Transform _transform;

    public void Construct(Engine engine) => _engine = engine;
    
    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_clickCheck == false && Input.GetKeyUp(KeyCode.Space))
        {
            _clickCheck = true;
            StartCoroutine(Moving());
        }
    }

    private IEnumerator Moving()
    {
        while (_engine.TryMove())
        {
            _transform.Translate(_engine.Speed * Time.deltaTime, 0, 0);
            yield return new WaitForFixedUpdate();
        }
    }
}
