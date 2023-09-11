using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Tower : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform target;
    [SerializeField] private float shootInterval = 1;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
        if (targets.Length == 0) 
        { 
            return; 
        }
        
        LookAtTarget(target);


    }


    private void LookAtTarget(Transform target)
    {
        Vector2 direction = target.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
    }

    IEnumerator Shoot()
    {
        while(true)
        {
            yield return new WaitForSeconds(shootInterval);
            GameObject projectileGameObject = Instantiate(projectilePrefab);
            
        }
    }
}
