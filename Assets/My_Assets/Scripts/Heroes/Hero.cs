using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class Hero
{
    public string name;
    public int cost;
    public GameObject prefab;
    public Sprite sprite;

    public Hero (string _name, int _cost, GameObject _prefab, Sprite _sprite)
    {
        name = _name;
        cost = _cost;
        prefab = _prefab;
        sprite = _sprite;
    }
}