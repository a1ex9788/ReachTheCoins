using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private int DURATION;

    public Text textCount;
    public static PlayerScore playerScore;

    public Text timer;
    private float count;

    public GameObject player;

    public EndPanelManagement endPanel;

    private void Start()
    {
        playerScore = this;
        DURATION = Messenger.duration;
    }

    private void Update()
    {
        count += Time.deltaTime;
        int time = DURATION - (int) count;
        timer.text = time + "";

        if (time <= 0) {
            player.GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<PlayerScore>().enabled = false;
            endPanel.ShowEndPanel(DURATION);
        }
    }

    public void CoinReached(int amount) {
        int aux = int.Parse(textCount.text) + amount;
        textCount.text = aux + "";
    }

    public void SetDuration(int d) {
        DURATION = d;
    }
}
