using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] GameObject nextTowerPrefab;

    public void Upgrade()
    {
        if (nextTowerPrefab == null)
        {
            return;
        }

        GameObject nextTower = Instantiate(nextTowerPrefab);
        nextTower.transform.position = transform.position;
        Destroy(gameObject);
    }
}
