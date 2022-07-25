using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalEngine : MonoBehaviour
{
    public float power = 50f;
    public float fuelSpend = 1;

    public bool clickCheck = false;
    public Battery Battery;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) & clickCheck == false)
        {
            clickCheck = !clickCheck;
            StartCoroutine("Spending");
            rb.AddForce(transform.right * power);
        }
    }

    IEnumerator Spending()
    {
        while (Battery.HasFuel())
        {
            Battery.Spend(fuelSpend);
            yield return new WaitForFixedUpdate();
        }
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
}
