using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int health;
    public static event Action<int> onDied;
    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        // other stuff you want to happen when enemy takes damage
        if(health < 0)
        {
            Destroy(gameObject);
            onDied?.Invoke(100);
        }
    }
}
