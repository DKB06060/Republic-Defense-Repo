using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Plot_Base : MonoBehaviour
{
    GameObject tower;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (tower != null)
            {
                return;
            }

            Tower towerToBuild = Build_Manager.main.GetSelectedTower();
            tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
        }
    }

    private void OnMouseDown()
    {
        if (tower != null)
        {
            return;
        }

        Tower towerToBuild = Build_Manager.main.GetSelectedTower();

        if (towerToBuild.cost > LevelManager.main.credits)
        {
            //Not enough credits
            return;
        }

        LevelManager.main.DecreaseCredits(towerToBuild.cost);

        tower = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
    }
}