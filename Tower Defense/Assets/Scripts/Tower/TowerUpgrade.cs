using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    private Tower selectedTower;

    public void Upgrade()
    {
        if (selectedTower == null) return;
        selectedTower.Upgrade();
    }

    public void SetSelectedTower(Tower tower) 
    {
        selectedTower = tower;    
    }
}
