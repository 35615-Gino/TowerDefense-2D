using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int health;

    private void Start()
    {
        health = 2;
    }
}
