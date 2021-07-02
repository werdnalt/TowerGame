using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int numResources;

    public bool ModifyResourceAmount(int numToModify)
    {
        // adding resources
        if (numToModify > 0)
        {
            numResources += numToModify;
            return true;
        }
        // removing resources
        else if (numResources >= 0 && numToModify < 0)
        {
            if (numResources + numToModify < 0)
            {
                numResources = 0;
            } else {
                numResources += numToModify;
            }
            return true;
        } else {
            return false;
        }
    }
}
