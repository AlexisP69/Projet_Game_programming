using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public float moveStep = 0;
    public GameObject lazer;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Player pressed jump button");

            // Faire appara�tre un fruit qui avance vers le haut
            // => M�thode qui fait appara�tre
            // => R�f�rence vers le fruit
            Instantiate(lazer, transform.position, Quaternion.identity);
        }
    }
}
