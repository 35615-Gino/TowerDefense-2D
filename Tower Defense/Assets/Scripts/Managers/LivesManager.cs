using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [SerializeField] public int lives;
    [SerializeField] private TextMeshProUGUI livesText;

    void Start()
    {
        UpdateLivesUI();
    }

    public void DecreaseLives(int amount)
    {
        lives -= amount;
        UpdateLivesUI();
    }

    void UpdateLivesUI()
    {
        livesText.text = lives.ToString();
    }
}
