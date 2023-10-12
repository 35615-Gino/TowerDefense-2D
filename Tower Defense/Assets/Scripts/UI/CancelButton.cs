using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour
{
    [SerializeField] private GameObject button;


    public void Cancel()
    {
        button.SetActive(false);
    }

}
