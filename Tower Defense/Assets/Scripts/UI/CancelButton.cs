using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CancelButton : MonoBehaviour
{
    [SerializeField] private Button button;

    public void Start()
    {
        button = GetComponent<Button>();
    }

    public void Cancel()
    {
        button.enabled = false;
    }

}
