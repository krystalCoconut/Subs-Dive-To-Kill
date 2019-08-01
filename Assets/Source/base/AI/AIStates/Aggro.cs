﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aggro : Behaviour
{

    public Aggro()
    {
        Name = "Aggro";
        detectionRange = 10;
        attackRange = 5f;
        agent = null;

    }

    public Aggro (string name, Agent driver, float activeRange = 0, float attkRange = 0)
    {
        Name = name;
        detectionRange = activeRange;
        attackRange = attkRange;
        agent = driver;
    }
 
    public override void Execute(ref Behaviour behaviour, Transform target)
    {
        
        base.Execute(ref behaviour, target); 
    }
}
