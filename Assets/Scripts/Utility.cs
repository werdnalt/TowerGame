using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static void Pay(int toPay, Hero hero)
    {
        if (hero.numResources > toPay)
        {
            hero.numResources -= toPay;
        }
    }
}
