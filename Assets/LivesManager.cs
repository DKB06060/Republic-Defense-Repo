using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    [Header("Configurables References")]
    [SerializeField] int startingLives = 100;

    [Header("Object References")]
    [SerializeField] Text livesText;

    int currentLives;

    void Start()
    {
        currentLives = startingLives;
    }

    void Update()
    {
        if (currentLives <= 0)
        {
            //Game Over
        }

        livesText.text = "Lives: " + currentLives;

        if (currentLives >= 60)
        {
            livesText.color = Color.green;
        }

        if (currentLives >= 40 && currentLives < 60)
        {
            livesText.color = Color.yellow;
        }

        if (currentLives < 40)
        {
            livesText.color = Color.red;
        }
    }

    public void IncreaseLives(int amount)
    {
        currentLives += amount;
    }

    public void DecreaseLives(int amount)
    {
        currentLives -= amount;
    }
}