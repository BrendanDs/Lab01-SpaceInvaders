using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectileShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy Projectile")
        {
            Destroy(collision.gameObject);
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
