using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 1f;


    public void EnemyTakeDamage(float damage)
    {
        health -= damage;
        if (health<=0)
            Destroy(gameObject);
    }
}
