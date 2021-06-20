using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float spawnRate;

    private float timePassed;
    private bool canSpawn;
    private BoxCollider spawnBounds;

    // Start is called before the first frame update
    void Start()
    {
        canSpawn = true;

        spawnBounds = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn)
        {
            SpawnEnemy();
            canSpawn = false;
            timePassed = 0.0f;
        }

        timePassed += Time.deltaTime;

        if (timePassed >= spawnRate)
        {
            canSpawn = true;
        }
    }

    private void SpawnEnemy()
    {


        Instantiate(enemyToSpawn, transform.position, transform.rotation);
    }
}
