using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [Header("Object References")]
    [SerializeField] GameObject mainMenuButtons;
    [SerializeField] GameObject settingsPanel;
    [SerializeField] GameObject enemiesPanel;
    [SerializeField] GameObject heroesPanel;
    [SerializeField] GameObject towersPanel;
    [SerializeField] GameObject levelSelectPanel;

    [Header("Script References")]
    [SerializeField] GameManager gameManager;

    private void Start()
    {
        gameManager.currentHero = "General Skywalker";
    }

    public void Play()
    {
        mainMenuButtons.SetActive(false);
        levelSelectPanel.SetActive(true);
    }

    public void Settings()
    {
        mainMenuButtons.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void Enemies()
    {
        mainMenuButtons.SetActive(false);
        enemiesPanel.SetActive(true);
    }

    public void Heroes()
    {
        mainMenuButtons.SetActive(false);
        heroesPanel.SetActive(true);
    }

    public void Towers()
    {
        mainMenuButtons.SetActive(false);
        towersPanel.SetActive(true);
    }

    public void Back()
    {
        mainMenuButtons.SetActive(true);
        settingsPanel.SetActive(false);
        enemiesPanel.SetActive(false);
        heroesPanel.SetActive(false);
        towersPanel.SetActive(false);
        levelSelectPanel.SetActive(false);
    }
}