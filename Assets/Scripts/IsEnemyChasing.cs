using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using Pada1.BBCore.Framework;

[Condition("MyConditions/IsEnemyChasing")]

public class IsEnemyChasing : ConditionBase
{
    [InParam("value")]
    public bool value;

    public override bool Check()
    {
        return GlobalBlackboard.EnemyChasing;
    }
}
