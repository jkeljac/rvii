using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacte : MonoBehaviour, IDamageable
{
    private int health;
    public int Health { get { return health; } }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }

}
