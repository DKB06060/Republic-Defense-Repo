using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour
{
    [Header("Object References")]
    [SerializeField] Text creditsUI;
    [SerializeField] GameObject towerMenu;
    [SerializeField] GameObject heroMenu;

    void Start()
    {
        towerMenu.SetActive(true);
        heroMenu.SetActive(false);
    }

    void Update()
    {
        creditsUI.text = "Current Credits: " + LevelManager.main.credits.ToString();
    }

    public void toggleHeroTab()
    {
        heroMenu.SetActive(!heroMenu.activeInHierarchy);
        towerMenu.SetActive(!towerMenu.activeInHierarchy);
    }
}