using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Projectile : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField] private float speed = 10;
    [SerializeField] private int damage;

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            ScoreManager sM = FindAnyObjectByType<ScoreManager>();

            Destroy(gameObject);
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
        }
    }
}
