using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCard : MonoBehaviour
{
    [Header("Object Referneces")]
    [SerializeField] string heroName;
    [SerializeField] GameObject part1;
    [SerializeField] GameObject infoTab;
    [SerializeField] GameObject heroPanel;
    [SerializeField] GameManager gameManager;

    string currentHero;

    private void Awake()
    {
        part1.SetActive(true);
        infoTab.SetActive(false);
    }

    public void View()
    {
        part1.SetActive(false);
        infoTab.SetActive(true);
    }

    public void Select()
    {
        currentHero = heroName;

        if (currentHero == "GeneralSkywalker")
        {
            gameManager.currentHero = gameManager.anakinPrefab;
        }

        if (currentHero == "GeneralKenobi")
        {
            gameManager.currentHero = gameManager.obiwanPrefab;
        }

        if (currentHero == "CaptainRex")
        {
            gameManager.currentHero = gameManager.captainRexPrefab;
        }

        if (currentHero == "CommanderCody")
        {
            gameManager.currentHero = gameManager.commanderCodyPrefab;
        }

        if (currentHero == "R2-D2")
        {
            gameManager.currentHero = gameManager.r2d2Prefab;
        }

        if (currentHero == "C-3PO")
        {
            gameManager.currentHero = gameManager.c3poPrefab;
        }
    }

    public void Back()
    {
        part1.SetActive(true);
        infoTab.SetActive(false);
    }

    public void BackToMain()
    {
        heroPanel.SetActive(false);
    }
}