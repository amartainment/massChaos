﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimax 
{
    public static char affinity;
    public static float prestige;
    public static float happinessIndex;


    public static char Affinity
    {
        get { return affinity; }
        set { affinity = value; }
    }

    public static float Prestige
    {
        get { return prestige; }
        set { prestige = value; }
    }

    public static float HappinessIndex
    {
        get { return happinessIndex; }
        set { happinessIndex = value; }
    }
}
