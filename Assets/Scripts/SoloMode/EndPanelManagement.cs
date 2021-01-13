using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndPanelManagement : MonoBehaviour
{
    public Text text;
    public Animator countAnimation;

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoHomeScreen() {
        SceneManager.LoadScene(0);

        GameObject aux = GameObject.Find("Music");
        AudioSource music = aux.GetComponent<AudioSource>();
        music.volume = 2f * music.volume;
    }

    public void ShowEndPanel(int duration)
    {
        text.text = "You got         coins in " + duration + "''";
        gameObject.SetActive(true);
        countAnimation.SetBool("EndPanelAnimation1", true);
    }
}
