using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreMultiplayer : MonoBehaviour
{
    private int COUNTLIMIT;

    public Text textCountPlayer1;
    public Text textCountPlayer2;

    public static PlayerScoreMultiplayer playerScore;

    public GameObject player1;
    public GameObject player2;

    public EndPanelManagementMultiplayer endPanel;

    private void Start()
    {
        playerScore = this;
        COUNTLIMIT = Messenger.maxScore;
    }

    private void Update()
    {
        if (int.Parse(textCountPlayer1.text) >= COUNTLIMIT)
        {
            player1.GetComponent<PlayerMovement>().enabled = false;
            player2.GetComponent<Player2Movement>().enabled = false;
            gameObject.GetComponent<PlayerScoreMultiplayer>().enabled = false;
            gameObject.GetComponent<CoinSpawnerMultiplayer>().enabled = false;
            endPanel.ShowEndPanel(1);
        } else if (int.Parse(textCountPlayer2.text) >= COUNTLIMIT)
        {
            player1.GetComponent<PlayerMovement>().enabled = false;
            player2.GetComponent<Player2Movement>().enabled = false;
            gameObject.GetComponent<PlayerScoreMultiplayer>().enabled = false;
            gameObject.GetComponent<CoinSpawnerMultiplayer>().enabled = false;
            endPanel.ShowEndPanel(2);
        }
    }

    public void CoinReached(int amount, int player)
    {
        if (player == 1)
        {
            int aux = int.Parse(textCountPlayer1.text) + amount;
            textCountPlayer1.text = aux + "";
        }
        else {
            int aux = int.Parse(textCountPlayer2.text) + amount;
            textCountPlayer2.text = aux + "";
        }
    }
}
