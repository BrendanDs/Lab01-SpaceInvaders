using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship3Proj : MonoBehaviour
{
    public GameObject enemyProjectile;
    public float timer;
    public float maxSpawn = 3;
    public float minSpawn = 1;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minSpawn, maxSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(enemyProjectile, transform.position, Quaternion.identity);
            timer = Random.Range(minSpawn, maxSpawn);
        }

    }
}
