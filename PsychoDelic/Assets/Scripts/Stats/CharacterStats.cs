using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public int maxHealth = 5;
    public int currentHealth { get; private set; }

    public Stat damage;
    public Stat fireRate;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (currentHealth <= 0)
        {
            Die();
        }

    }

    public virtual void Die()
    {
        //This will be overwritten
        Debug.Log(transform.name + " died.");
    }
   
}
