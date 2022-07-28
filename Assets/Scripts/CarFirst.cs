using System.Collections;
using UnityEngine;

public class CarFirst : MonoBehaviour
{
    public GasEngine GasEngine;
    public GasTank GasTank;

    private bool clickCheck = false;
    private Rigidbody2D rigidbody;
    private Transform _transform;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (clickCheck == false && Input.GetKeyUp(KeyCode.Space))
        {
            clickCheck = true;
            StartCoroutine(Spending());
            rigidbody.AddForce(_transform.right * GasEngine.Power);
        }
    }

    private IEnumerator Spending()
    {
        while (GasTank.HasFuel())
        {
            GasTank.Spend(GasEngine.FuelSpend);
            yield return new WaitForFixedUpdate();
        }
        rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
    }
}
