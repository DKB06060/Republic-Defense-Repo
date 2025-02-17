using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    [Header("Object References")]
    [SerializeField] GameObject geonosisTab;
    [SerializeField] GameObject geonosisSelect;
    [SerializeField] GameObject kashyyykTab;
    [SerializeField] GameObject kashyyykSelect;
    [SerializeField] GameObject feluciaTab;
    [SerializeField] GameObject feluciaSelect;

    [Header("Script References")]
    [SerializeField] GameManager gameManager;

    public void Geonosis()
    {
        geonosisTab.SetActive(false);
        kashyyykTab.SetActive(false);
        feluciaTab.SetActive(false);
        geonosisSelect.SetActive(true);
        gameManager.currentMap = "Geonosis";
    }

    public void Kashyyyk()
    {
        geonosisTab.SetActive(false);
        kashyyykTab.SetActive(false);
        feluciaTab.SetActive(false);
        kashyyykSelect.SetActive(true);
        gameManager.currentMap = "Kashyyyk";
    }

    public void Felucia()
    {
        geonosisTab.SetActive(false);
        kashyyykTab.SetActive(false);
        feluciaTab.SetActive(false);
        feluciaSelect.SetActive(true);
        gameManager.currentMap = "Felucia";
    }

    public void Easy()
    {
        gameManager.currentDifficulty = "Easy";
        SceneManager.LoadScene(gameManager.currentMap);
    }

    public void Medium()
    {
        gameManager.currentDifficulty = "Medium";
        SceneManager.LoadScene(gameManager.currentMap);
    }

    public void Hard()
    {
        gameManager.currentDifficulty = "Hard";
        SceneManager.LoadScene(gameManager.currentMap);
    }

    public void Back()
    {
        geonosisTab.SetActive(true);
        kashyyykTab.SetActive(true);
        feluciaTab.SetActive(true);
        geonosisSelect.SetActive(false);
        kashyyykSelect.SetActive(false);
        feluciaSelect.SetActive(false);
    }
}