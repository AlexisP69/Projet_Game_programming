using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Ennemi : MonoBehaviour
{
    public GameObject player1;
    public Score score;

    public void Update()
    {
        Health healthPlayer1 = gameObject.GetComponent<Health>();
        score.UpdateScore(healthPlayer1.currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            Health ennemiHealth = gameObject.GetComponent<Health>();
            if (ennemiHealth != null)
            {
                Health healthPlayer1 = player1.GetComponent<Health>();
            if (healthPlayer1 != null)
            {
                if (ennemiHealth.currentHealth < healthPlayer1.currentHealth)
                {
                    Debug.Log("Trigger with player1 with hight health");
                    healthPlayer1.ApplyHeal(ennemiHealth.currentHealth);
                    Debug.Log(healthPlayer1.currentHealth);
                        Destroy(gameObject);
                        Destroy(collision.gameObject);
                    }else if (ennemiHealth.currentHealth > healthPlayer1.currentHealth) {
                    Destroy(player1);
                    Destroy(collision.gameObject);
                    SceneManager.LoadScene("Menu");
                }
                }
            }
    }
}