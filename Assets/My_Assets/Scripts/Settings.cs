using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [Header("Object References")]
    [SerializeField] GameObject masterSlider;
    [SerializeField] GameObject musicSlider;
    [SerializeField] GameObject sfxSlider;
    [SerializeField] AudioMixer myMixer;
    [SerializeField] TMP_InputField playerNameInput;

    [Header("Script References")]
    [SerializeField] GameManager gameManager;

    private void Start()
    {
        if (PlayerPrefs.HasKey("masterVolume") && PlayerPrefs.HasKey("musicVolume") && PlayerPrefs.HasKey("sfxVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
        }

        playerNameInput.text = gameManager.playerName;
    }

    public void SetPlayerName()
    {
        gameManager.playerName = playerNameInput.text;
    }

    public void SetMusicVolume()
    {
        float masterVolume = masterSlider.GetComponent<Slider>().value;
        float musicVolume = musicSlider.GetComponent<Slider>().value;
        float sfxVolume = sfxSlider.GetComponent<Slider>().value;

        myMixer.SetFloat("Master", masterVolume);
        myMixer.SetFloat("Music", musicVolume);
        myMixer.SetFloat("SFX", sfxVolume);

        PlayerPrefs.SetFloat("masterVolume", masterVolume);
        PlayerPrefs.SetFloat("musicVolume", musicVolume);
        PlayerPrefs.SetFloat("sfxVolume", sfxVolume);
    }

    void LoadVolume()
    {
        masterSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("masterVolume");
        musicSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("musicVolume");
        sfxSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("sfxVolume");

        SetMusicVolume();
    }
}