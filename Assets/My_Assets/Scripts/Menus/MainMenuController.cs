using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [Header("Object References")]
    [SerializeField] GameObject mainMenuButtons;
    public void Play()
    {

    }

    public void Settings()
    {
        mainMenuButtons.SetActive(false);
    }

    public void Enemies()
    {
        mainMenuButtons.SetActive(false);
    }

    public void Heroes()
    {
        mainMenuButtons.SetActive(false);
    }

    public void Towers()
    {
        mainMenuButtons.SetActive(false);
    }
}