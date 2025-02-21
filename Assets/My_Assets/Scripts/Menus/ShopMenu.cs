using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour
{
    [Header("Object References")]
    [SerializeField] Text creditsUI;

    private void Update()
    {
        creditsUI.text = "Current Credits: " + LevelManager.main.credits.ToString();
    }

    public void SetSelected()
    {

    }
}