using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    [Header("Button Objects")]
    [SerializeField] Button playButton;
    [SerializeField] Button settingsButton;
    [SerializeField] Button enemiesButton;
    [SerializeField] Button heroesButton;
    [SerializeField] Button towersButton;

    [Header("Script References")]
    [SerializeField] MainMenuController mainMenuScript;

    public void Play()
    {
        mainMenuScript.Play();
    }

    public void Settings()
    {
        mainMenuScript.Settings();
    }

    public void Enemies()
    {
        mainMenuScript.Enemies();
    }

    public void Heroes()
    {
        mainMenuScript.Heroes();
    }

    public void Towers()
    {
        mainMenuScript.Towers();
    }
}