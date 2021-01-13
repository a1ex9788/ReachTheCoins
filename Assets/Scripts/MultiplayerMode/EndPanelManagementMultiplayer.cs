using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndPanelManagementMultiplayer : MonoBehaviour
{
    public Text text;
    public Animator scoreAnimation;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoHomeScreen()
    {
        SceneManager.LoadScene(0);

        GameObject aux = GameObject.Find("Music");
        AudioSource music = aux.GetComponent<AudioSource>();
        music.volume = 2f * music.volume;
    }

    public void ShowEndPanel(int winner)
    {
        if (winner == 1)
        {
            text.text = "Player 1 won";
        }
        else {
            text.text = "Player 2 won";
        }

        gameObject.SetActive(true);
        scoreAnimation.SetBool("EndPanelAnimation2", true);
    }
}
