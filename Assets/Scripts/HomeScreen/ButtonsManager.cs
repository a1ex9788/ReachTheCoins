using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour
{
    public GameObject panelSolo1;
    public GameObject panelSolo2;
    public GameObject panelMultiplayer1;
    public GameObject panelMultiplayer2;
    
    public Dropdown dropdownSolo;
    public Dropdown dropdownMultiplayer;

    public GameObject mainPanel;
    public GameObject settingsPanel;

    public Toggle toggle;
    public Slider slider;

    public void ChooseSolo() {
        if (panelSolo1.activeSelf == true) {
            panelSolo1.SetActive(false);
            panelSolo2.SetActive(true);
        } else {
            panelSolo1.SetActive(true);
            panelSolo2.SetActive(false);
        }
    }

    public void PlaySolo() {
        Messenger.duration = int.Parse(dropdownSolo.options.ToArray()[dropdownSolo.value].text);
        SceneManager.LoadScene("SoloMode");

        GameObject aux = GameObject.Find("Music");
        AudioSource music = aux.GetComponent<AudioSource>();
        music.volume = 0.5f * music.volume;
    }



    public void ChooseMultiplayer()
    {
        if (panelMultiplayer1.activeSelf == true) {
            panelMultiplayer1.SetActive(false);
            panelMultiplayer2.SetActive(true);
        } else {
            panelMultiplayer1.SetActive(true);
            panelMultiplayer2.SetActive(false);
        }
    }

    public void PlayMultiplayer() {
        Messenger.maxScore = int.Parse(dropdownMultiplayer.options.ToArray()[dropdownMultiplayer.value].text);
        SceneManager.LoadScene("MultiplayerMode");

        GameObject aux = GameObject.Find("Music");
        AudioSource music = aux.GetComponent<AudioSource>();
        music.volume = 0.5f * music.volume;
    }

    public void GoSettings() {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void ReturnFromSettings() {
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void ToggleManagement() {
        if (toggle.isOn)
        {
            GameObject aux = GameObject.Find("Music");
            AudioSource music = aux.GetComponent<AudioSource>();
            music.volume = Messenger.currentVolume;
        }
        else {
            GameObject aux = GameObject.Find("Music");
            AudioSource music = aux.GetComponent<AudioSource>();
            music.volume = 0;
        }
    }

    public void SliderManagement() {
        Messenger.currentVolume = slider.value;
        GameObject aux = GameObject.Find("Music");
        AudioSource music = aux.GetComponent<AudioSource>();
        music.volume = slider.value;
    }

    public void Exit() {
        Application.Quit();
    }
}
