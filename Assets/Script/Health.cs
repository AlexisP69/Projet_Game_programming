using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int minHealth;
    public int maxHealth;
    public int ennemiCount;

    void Start()
    {
        currentHealth = Random.Range(minHealth, maxHealth);
        if (SceneManager.GetActiveScene().name == "v2")
        {
            ennemiCount = 3;
        }
        else
        {
            ennemiCount = 2;
        }
    }
    public void ApplyHeal(int amount)
    {
        maxHealth = 100;
        ennemiCount -= 1;
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);
        if (ennemiCount <= 0 && SceneManager.GetActiveScene().name == "v1")
        {
            SceneManager.LoadScene("v2");
        }
        if (ennemiCount <= 0 && SceneManager.GetActiveScene().name == "v2")
        {
            SceneManager.LoadScene("Win");
        }
    }
}