using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
public class Player : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public float moveStep = 0;
    public GameObject lazer;

    void Update()
    {
        if (Input.GetButtonDown("Vertical"))
        {
            float direction = Input.GetAxisRaw("Vertical");
            Move(direction * moveStep);
        }
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Player pressed jump button");

            // Faire apparaître un fruit qui avance vers le haut
            // => Méthode qui fait apparaître
            // => Référence vers le fruit
            Instantiate(lazer, transform.position, Quaternion.identity);
        }
    }
    private void Move(float distance)
    {
        Vector3 newPosition = transform.position + distance * Vector3.up;
        transform.position = newPosition;

        /// TODO: Modifier ce test pour que cela fonctionne avec un nombre pair d'animaux

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == gameObject)
        {
            Health health = gameObject.GetComponent<Health>();
            if (health != null)
            {
                Debug.Log(health.currentHealth);
                Health healthPlayer1 = collision.gameObject.GetComponent<Health>();
                if (healthPlayer1 != null)
                {
                    Debug.Log(healthPlayer1.currentHealth);
                    if (health.currentHealth < healthPlayer1.currentHealth)
                    {
                        Debug.Log("Trigger with player1 with low health");
                        Destroy(collision.gameObject);
                    }
                }
            }
        }
    }
}
