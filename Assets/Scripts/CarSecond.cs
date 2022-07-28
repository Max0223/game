using System.Collections;
using UnityEngine;

public class CarSecond : MonoBehaviour
{
    public ElectricalEngine ElectricalEngine;
    public Battery Battery;

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
            rigidbody.AddForce(_transform.right * ElectricalEngine.Power);
        }
    }

    private IEnumerator Spending()
    {
        while (Battery.HasEnergy())
        {
            Battery.Spend(ElectricalEngine.EnergySpend);
            yield return new WaitForFixedUpdate();
        }
        rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
    }
}

