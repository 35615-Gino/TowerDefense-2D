using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    [SerializeField] private GameObject cancelButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //towerSlots[towerSlotIndex].tower
    }

    public void UpgradeButton()
    {
        cancelButton.SetActive(true);
    }
}
