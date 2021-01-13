using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManagerMultiplayer : MonoBehaviour
{
    GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GAMEMANAGER");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player1")
        {
            PlayerScoreMultiplayer.playerScore.CoinReached(1, 1);
        }
        else {
            PlayerScoreMultiplayer.playerScore.CoinReached(1, 2);
        }
        
        gameManager.GetComponent<CoinSound>().PlaySound();
        Destroy(gameObject);
    }
}
