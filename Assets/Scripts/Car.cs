using System.Collections;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private Engine _engine;

    private bool clickCheck = false;
    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (clickCheck == false && Input.GetKeyUp(KeyCode.Space))
        {
            clickCheck = true;
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
