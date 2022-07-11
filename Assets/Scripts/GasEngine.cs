using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasEngine : MonoBehaviour
{
    public float power = 15f;
    private bool clickCheck = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) & clickCheck == false)
        {
            clickCheck = true;
            rb.AddForce(transform.right * power);
        }
    }
}
