using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    private float tank = 1000f;

    public bool HasFuel() => tank > 0;

    public void Spend(float cost) => tank -= cost;
}
