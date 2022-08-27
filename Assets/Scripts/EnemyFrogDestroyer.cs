using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFrogDestroyer : EnemyBase
{
    private float speed = 2;
    void Start()
    {
        health = 100;
        damage = 5;
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
