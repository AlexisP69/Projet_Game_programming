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

            // Faire apparaître un fruit qui avance vers le haut
            // => Méthode qui fait apparaître
            // => Référence vers le fruit
            Instantiate(lazer, transform.position, Quaternion.identity);
        }
    }
}
