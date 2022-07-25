using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasEngine : MonoBehaviour
{
    public float power = 100f;
    public float fuelSpend = 2;

    private bool clickCheck = false;
    public GasTank GasTank;
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
        while (GasTank.HasFuel())
        {
            GasTank.Spend(fuelSpend);
            yield return new WaitForFixedUpdate();
        }
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
}
