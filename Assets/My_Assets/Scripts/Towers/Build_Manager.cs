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
    [SerializeField] List<Tower> towers;
    [SerializeField] Button heroButton;
 
    [Header("Hero References")]
    [SerializeField] GameObject rexPrefab;
    [SerializeField] Sprite rexSprite;
    [SerializeField] GameObject codyPrefab;
    [SerializeField] Sprite codySprite;
    [SerializeField] GameObject anakinPrefab;
    [SerializeField] Sprite anakinSprite;
    [SerializeField] GameObject kenobiPrefab;
    [SerializeField] Sprite kenobiSprite;
    [SerializeField] GameObject rd2dPrefab;
    [SerializeField] Sprite rd2dSprite;
    [SerializeField] GameObject c3poPrefab;
    [SerializeField] Sprite c3poSprite;

    int selectedTower = 0;

    void Awake()
    {
        main = this;
    }
    
    public Tower GetSelectedTower()
    {
        return towers[selectedTower];
    }

    public void SetSelectedTower(int _selectedTower)
    {
        selectedTower = _selectedTower;
    }

    public void SetTowerType(string towerType)
    {
        GetTowerType(towerType);
    }

    public string GetTowerType(string _type)
    {
        return _type;
    }
}