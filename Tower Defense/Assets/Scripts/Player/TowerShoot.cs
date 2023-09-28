using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TowerShoot : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float shootInterval = 1;
    private TargetDetection targetDetection;

    // Start is called before the first frame update
    void Start()
    {
        targetDetection = GetComponent<TargetDetection>();
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(shootInterval);
            GameObject projectileGameObject = Instantiate(projectilePrefab, gameObject.transform);
            projectileGameObject.transform.position = transform.position;
            Projectile projectile = projectileGameObject.GetComponent<Projectile>();
            projectile.target = targetDetection.GetTarget();
        }
    }
}