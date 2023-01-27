using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.Experimental.GraphView.GraphView;
public class Joueur : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public Score score;
    public float moveStep = 0;
    public GameObject lazer;

    
    void Update()
    {
        Health healthPlayer1 = player1.GetComponent<Health>();
        score.UpdateScore(healthPlayer1.currentHealth);
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
    }
