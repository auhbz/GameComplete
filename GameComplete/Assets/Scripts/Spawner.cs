using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] bonks;

    public float startSpawnTime;
    private float spawnTime;

    public float minSpawnTime;
    public float decreaseSpawnTime;
    
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
            if (spawnTime <= 0) {
                //spawn bonk
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject randomBonk = bonks[Random.Range(0, bonks.Length)];

                Instantiate(randomBonk, randomSpawnPoint.position, Quaternion.identity);

                if (startSpawnTime > minSpawnTime) {
                    startSpawnTime -= decreaseSpawnTime;
                }
                spawnTime = startSpawnTime;
                } else {
                    spawnTime -= Time.deltaTime;
                }
        }
        
    }
}
