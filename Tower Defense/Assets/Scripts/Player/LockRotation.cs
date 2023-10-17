using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockRotation : MonoBehaviour
{
    private Quaternion rotationLock;
    [SerializeField] private GameObject textPosition;

    void Awake()
    {
        rotationLock = transform.rotation;
    }

    void LateUpdate()
    {
        transform.rotation = rotationLock;

        transform.position = textPosition.transform.position;
        transform.rotation = Quaternion.identity;
    }
}
