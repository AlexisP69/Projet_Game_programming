using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Ennemi : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject Laser;
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
                        Debug.Log("Trigger with player1 with low health");
                    healthPlayer1.ApplyHeal(ennemiHealth.currentHealth);
                    Debug.Log(healthPlayer1.currentHealth);
                        Destroy(gameObject);
                        Destroy(collision.gameObject);
                    }
                }
            }
        }
}
            /*if (collision.gameObject == Laser)
            {
                Health health = player2.GetComponent<Health>();
                if (health != null)
                {
                    Health healthPlayer1 = player1.GetComponent<Health>();
                    if (healthPlayer1 != null)
                    {
                        if (health.currentHealth < healthPlayer1.currentHealth)
                        {
                            Debug.Log("Trigger with player1 with low health");
                            Destroy(gameObject);
                            Destroy(collision.gameObject);
                        }
                    }
                }
            }
            else if (collision.gameObject == Laser)
            {
                Health health = player3.GetComponent<Health>();
                if (health != null)
                {
                    Health healthPlayer1 = player1.GetComponent<Health>();
                    if (healthPlayer1 != null)
                    {
                        if (health.currentHealth < healthPlayer1.currentHealth)
                        {
                            Debug.Log("Trigger with player1 with low health");
                            Destroy(gameObject);
                            Destroy(collision.gameObject);
                        }
                        else
                        {
                            Debug.Log("T'as perdu");
                            Destroy(gameObject);
                            Destroy(player1);
                        }
                    }
                }
            }*/