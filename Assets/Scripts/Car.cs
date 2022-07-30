using System.Collections;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private Engine Engine;

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
        while (Engine.HasFuel())
        {
            _transform.Translate(Engine.Speed * Time.deltaTime, 0, 0);
            Engine.Spend(Engine.FuelSpend);
            yield return new WaitForFixedUpdate();
        }
        _transform.Translate(0, 0, 0);
    }
}
