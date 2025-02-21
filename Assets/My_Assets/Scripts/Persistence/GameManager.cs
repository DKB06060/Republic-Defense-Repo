using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameManager", menuName = "ScriptableObjects", order = 1)]
public class GameManager : ScriptableObject
{
    public Tower anakinPrefab;
    public Tower obiwanPrefab;
    public Tower captainRexPrefab;
    public Tower commanderCodyPrefab;
    public Tower r2d2Prefab;
    public Tower c3poPrefab;

    public Tower currentHero;
    public string currentMap;
    public string currentDifficulty;

    public string playerName;
}