using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{    
    public int health = 100;
    public int maxHealth = 100;

    public void TakeHit(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
