using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_Manager : MonoBehaviour
{
    public static Build_Manager main;

    [Header("Script References")]
    [SerializeField] GameManager gameManager;

    [Header("Configurables References")]


    [Header("Object References")]
    [SerializeField] List<Tower> towers;
    [SerializeField] List<Hero> heroes;

    int selectedTower = 0;
    int selectedHero = 0;

    void Awake()
    {
        main = this;
    }
    
    public Tower GetSelectedTower()
    {
        return towers[selectedTower];
    }

    public Hero GetSelectedHero()
    {
        return heroes[selectedHero];
    }

    public void SetSelectedTower(int _selectedTower)
    {
        selectedTower = _selectedTower;
    }

    public void SetSelectedHero(int _selectedHero)
    {
        selectedHero = _selectedHero;
    }
}