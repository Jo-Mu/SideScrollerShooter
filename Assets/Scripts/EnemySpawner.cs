using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public bool canSpawn = true;

    private const float maxY = 8.75f;
    private const float startingX = 22.0f;
    private const float spawnWaitTime = .2f;

    private float randomY = 0.0f;

	void Start ()
    {
        StartCoroutine(EnemySpawnTimer());
	}
	
	void Update ()
    {
		
	}

    IEnumerator EnemySpawnTimer()
    {
        while (canSpawn)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnWaitTime);
        }
    }

    void SpawnEnemy()
    {
        randomY = Random.Range(-maxY, maxY);
        Instantiate(enemyToSpawn, new Vector3(startingX, randomY, 0), Quaternion.identity);
    }
}
