using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasEngine : MonoBehaviour
{
    public float power = 3f;
    public float tank = 30f;
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
            StartCoroutine("Moving");
        }
    }

    IEnumerator Moving()
    {
        while (tank > 0)
        {
            rb.velocity = new Vector2(power, rb.velocity.y);    //движение
            tank -= power;                                      //расход топлива
            Debug.Log(tank);
            yield return new WaitForSeconds(0.5f);
        }
        rb.velocity = new Vector2(0, rb.velocity.y);            //остановка
    }
}
