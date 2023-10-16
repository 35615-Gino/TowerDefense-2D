using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    private Tower selectedTower;
    [SerializeField] private ScoreManager scoreCount;
    [SerializeField] private int upgradeCost;

    public void Upgrade()
    {
        if (selectedTower == null) return;
        selectedTower.Upgrade();
        scoreCount.UpdateScore();
    }

    public void SetSelectedTower(Tower tower) 
    {
        if(scoreCount.scoreCount >= upgradeCost)
        {
            scoreCount.scoreCount -= upgradeCost;
            selectedTower = tower;
        }
    }
}
