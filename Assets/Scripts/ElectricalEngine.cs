using System.Collections;
using UnityEngine;

public class ElectricalEngine : MonoBehaviour
{
    public float power = 50f;
    public float energySpend = 1;

    private bool clickCheck = false;
    public Battery Battery;
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
        while (Battery.HasEnergy())
        {
            Battery.Spend(energySpend);
            yield return new WaitForFixedUpdate();
        }
        rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
    }
}
