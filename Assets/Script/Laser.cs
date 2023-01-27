using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 4f;

    void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.right;
       // Health healthPlayer1 = player1.GetComponent<Health>();
       // Debug.Log(healthPlayer1.currentHealth);
    }
    /* private void OnTriggerEnter2D(Collider2D collision)
     {
         Debug.Log("Trigger with Animal");

         Destroy(gameObject);
         Destroy(collision.gameObject);
     }*/
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player2)
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
        else if (collision.gameObject == player3)
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
                    }else
                    {
                        Debug.Log("T'as perdu");
                        Destroy(gameObject);
                        Destroy(player1);
                    }
                }
            }
        }*/

        /*private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject == player2)
            {
                Destroy(player2);
                Destroy(gameObject);
            }
            else if (collision.gameObject == player3)
            {
                if (player3.GetComponent<Health>().currentHealth > player1.GetComponent<Health>().currentHealth)
                {
                    Destroy(player1);
                    Destroy(gameObject);
                }
                else
                {
                    Destroy(player3);
                    Destroy(gameObject);
                }
            }
        }*/
    }
