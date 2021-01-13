using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GAMEMANAGER");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerScore.playerScore.CoinReached(1);
        gameManager.GetComponent<CoinSound>().PlaySound();
        gameManager.GetComponent<CoinSpawner>().NewCoin();
        Destroy(gameObject);
    }
}
