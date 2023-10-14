using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.EventSystems;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] public int scoreCount;
   

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
        EnemyHealth.onDied += AddPoints;
        
    }

    // Update is called once per frame
    private void UpdateScore()
    {
        scoreText.text = "" + scoreCount;
    }

    public void AddPoints(int score)
    {
        this.scoreCount += score;
        UpdateScore();
        
    }
    
}
