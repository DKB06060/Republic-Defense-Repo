using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Build_Manager : MonoBehaviour
{
    public static Build_Manager main;

    [Header("Script References")]
    [SerializeField] GameManager gameManager;

    [Header("Object References")]
    [SerializeField] List<GameObject> towers;

    int selectedTower = 0;

    void Awake()
    {
        main = this;
    }
    
    public GameObject GetSelectedTower()
    {
        return towers[selectedTower];
    }

    public void SetSelectedTower(int _selectedTower)
    {
        selectedTower = _selectedTower;
    }
}