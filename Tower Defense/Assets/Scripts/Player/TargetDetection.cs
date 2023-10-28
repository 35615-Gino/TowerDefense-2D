using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

public class TargetDetection : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
        if (targets.Length == 0)
        {
            return;
        }
        //target = targets[0].transform;

        float nearestDistance = 100;
        for (int i = 0; i < targets.Length; i++)
        {
            float distance = Vector2.Distance(transform.position, targets[i].transform.position);
            if (distance < nearestDistance)
            {
                target = targets[i].transform;
                nearestDistance = distance;
            }
        }
        Detect(target);
    }
    // Update is called once per frame
    void Detect(Transform target)
    {
        Vector2 direction = target.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
    }
    
    public Transform GetTarget()
    {
        return target;
    }
}