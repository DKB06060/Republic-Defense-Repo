using Newtonsoft.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    [Header("Object References")]
    [SerializeField] public Transform startPoint;
    [SerializeField] public Transform[] path;
    [SerializeField] public int credits;
    [SerializeField] public int startingCredits = 200;

    void Awake()
    {
        main = this;
    }

    void Start()
    {
        credits = startingCredits;
    }

    public void IncreaseCredits(int amount)
    {
        credits += amount;
    }

    public bool DecreaseCredits(int amount)
    {
        if (amount <= credits)
        {
            credits -= amount;
            return true;
        }
        else
        {
            return false;
            //Not enough currency
        }
    }
}