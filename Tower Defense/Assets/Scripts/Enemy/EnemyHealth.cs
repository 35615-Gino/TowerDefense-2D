using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int health;



    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        // other stuff you want to happen when enemy takes damage
        if(health < 0)
        {
            Destroy(gameObject);
        }
    }
}
