using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    //test
    protected override void Die()
    {
        base.Die();
        Debug.Log("Enemy died");
    }
}