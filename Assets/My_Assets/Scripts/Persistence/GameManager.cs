using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameManager", menuName = "ScriptableObjects", order = 1)]
public class GameManager : ScriptableObject
{
    public GameObject anakinPrefab;
    public GameObject obiwanPrefab;
    public GameObject captainRexPrefab;
    public GameObject commanderCodyPrefab;
    public GameObject r2d2Prefab;
    public GameObject c3poPrefab;

    public string currentHero;
    public string currentMap;
    public string currentDifficulty;

    public string playerName;
}