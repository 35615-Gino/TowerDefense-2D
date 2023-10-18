using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueGame : MonoBehaviour
{
    [SerializeField] private GameObject[] ui;

    // Start is called before the first frame update
    public void Continue()
    {
        Time.timeScale = 1.0f;
        ui[0].SetActive(false);
        ui[1].SetActive(true);
    }
}
