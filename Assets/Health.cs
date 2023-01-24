using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int minHealth;
    public int maxHealth;

    void Start()
    {
        currentHealth = Random.Range(minHealth, maxHealth);
    }

    public void ApplyDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Max(currentHealth, 0);
    }

    public void ApplyHeal(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);
    }
}