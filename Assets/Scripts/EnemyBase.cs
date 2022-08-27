using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    protected float health = 0;
    protected float damage = 0;
    protected float cd = 0;
    protected float stamina = 0;
    protected float poise = 0;
    protected float bleadingDamage = 0;

    protected virtual void Spawn()
    {
        // SPAWNING IDAIDAI
    }

    protected virtual void Death()
    {
        // SPAWNING IDAIDAI
    }
}
