using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCard : MonoBehaviour
{
    [Header("Object Referneces")]
    [SerializeField] GameObject nameText;
    [SerializeField] GameObject image;
    [SerializeField] GameObject viewButton;
    [SerializeField] GameObject infoTab;

    private void Awake()
    {
        nameText.SetActive(true);
        image.SetActive(true);
        viewButton.SetActive(true);
        infoTab.SetActive(false);
    }

    public void View()
    {
        nameText.SetActive(false);
        image.SetActive(false);
        viewButton.SetActive(false);
        infoTab.SetActive(true);
    }

    public void Back()
    {
        nameText.SetActive(true);
        image.SetActive(true);
        viewButton.SetActive(true);
        infoTab.SetActive(false);
    }
}