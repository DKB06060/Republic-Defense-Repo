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

            GameObject towerToBuild = Build_Manager.main.GetSelectedTower();
            Tower_Info towerToBuildScript = towerToBuild.GetComponent<Tower_Info>();

            if (towerToBuildScript.cost > LevelManager.main.credits)
            {
                //Not enough credits
                return;
            }

            LevelManager.main.DecreaseCredits(towerToBuildScript.cost);

            tower = Instantiate(towerToBuildScript.prefab, transform.position, Quaternion.identity);
        }
    }

    private void OnMouseDown()
    {
        if (tower != null)
        {
            return;
        }

        GameObject towerToBuild = Build_Manager.main.GetSelectedTower();
        Tower_Info towerToBuildScript = towerToBuild.GetComponent<Tower_Info>();

        if (towerToBuildScript.cost > LevelManager.main.credits)
        {
            //Not enough credits
            return;
        }

        LevelManager.main.DecreaseCredits(towerToBuildScript.cost);

        tower = Instantiate(towerToBuildScript.prefab, transform.position, Quaternion.identity);
    }
}