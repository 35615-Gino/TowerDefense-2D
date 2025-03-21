using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TowerUpgrade))]
public class TowerPlacement : MonoBehaviour
{
    [SerializeField] private Tower towerPrefab;
    [SerializeField] private TowerSlot[] towerSlots;
    [SerializeField] private ScoreManager scoreCount;
    [SerializeField] private int placementCost;
    
    private TowerUpgrade towerUpgrade;

    private void Start()
    {
        towerUpgrade = GetComponent<TowerUpgrade>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                int towerSlotIndex = Array.IndexOf(towerSlots, hit.collider.GetComponent<TowerSlot>());
                if (towerSlotIndex != -1)
                {
                    if (towerSlots[towerSlotIndex].tower != null)
                    {
                        towerUpgrade.SetSelectedTower(towerSlots[towerSlotIndex].tower);
                    } else
                    {
                        if(scoreCount.scoreCount >= placementCost)
                        {
                            scoreCount.scoreCount -= placementCost;
                            scoreCount.UpdateScore();
                            PlaceTower(towerSlotIndex);
                        }
                    }
                }
            }
        }
    }

    void PlaceTower(int towerSlotIndex)
    {
        Tower tower = Instantiate(towerPrefab);
        towerSlots[towerSlotIndex].tower = tower;
        tower.transform.position = towerSlots[towerSlotIndex].transform.position;
    }
}