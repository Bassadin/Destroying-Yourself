using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnTimer = 0;

    public float spawnRate = .3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnRate)
        {
            Instantiate(enemyPrefab, new Vector3(transform.position.x, transform.position.y + Random.Range(-4.2f, 4.2f)), Quaternion.Euler(0, 0, Random.Range(-15f, 15f)));
            spawnTimer = 0;
        }
    }
}
