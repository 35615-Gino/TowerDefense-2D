using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Analytics;

public class GameEnd : MonoBehaviour
{
    public int damageAmount = 1;
    [SerializeField] private LivesManager lives;
    [SerializeField] private GameObject GameOverUI;

    private void Update()
    {
        if (lives.lives == 0)
        {
            Time.timeScale = 0;
            GameOverUI.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            lives.DecreaseLives(1);
            Destroy(collision.gameObject);
        }
    }
}
