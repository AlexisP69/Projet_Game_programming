using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    void Update()
    {
        if (player1.GetComponent<Health>().currentHealth <= 0)
        {
            Debug.Log("Player 2 wins!");
        }
        else if (player2.GetComponent<Health>().currentHealth <= 0)
        {
            Debug.Log("Player 1 wins!");
            player1.GetComponent<Health>().currentHealth += Random.Range(20, 40);
        }
        else if (player3.GetComponent<Health>().currentHealth <= 0)
        {
            Debug.Log("Player 3 wins!");
        }
    }
}
