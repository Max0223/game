using System.Collections;
using UnityEngine;

public class GasEngine : MonoBehaviour
{
    public float power = 100f;
    public float fuelSpend = 2;

    private bool clickCheck = false;
    public GasTank GasTank;
    private new Rigidbody2D rigidbody;
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
            rigidbody.AddForce(_transform.right * power);
        }
    }

    private IEnumerator Spending()
    {
        while (GasTank.HasFuel())
        {
            GasTank.Spend(fuelSpend);
            yield return new WaitForFixedUpdate();
        }
        rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
    }
}
