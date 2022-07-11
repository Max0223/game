using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasTank : MonoBehaviour
{
    public float tank = 150f;
    public float spending = 15f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    IEnumerator Spend()
    {
        while (tank > 0)
        {
            tank -= spending;
            Debug.Log(tank);
            yield return new WaitForSeconds(0.5f);
        }
        rb.velocity = new Vector2(0, rb.velocity.y);
    }

    public void HasFuel()
    {

    }
}