using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject[] ui;


    private void Start()
    {
        ui[0].SetActive(false);
        ui[1].SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale=  ra0f;
            Pause();
        }
    }

    private void Pause()
    {
        ui[0].SetActive(true);
        ui[1].SetActive(false);
    }
}