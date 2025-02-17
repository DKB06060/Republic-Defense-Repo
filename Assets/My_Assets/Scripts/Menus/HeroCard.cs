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
        gameManager.currentHero = heroName;
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