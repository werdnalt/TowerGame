using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public int numAvailable;
    public int value;

    public int Harvest()
    {
        numAvailable--;
        return value;
    }

    void Update()
    {
        if (numAvailable <= 0) Destroy(this.gameObject);
    }
}
