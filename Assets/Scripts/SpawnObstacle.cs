using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    void ObstacleSpawn()
    {
        int obstacleSpawnIndex = Random.Range(0,3);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    
    }
    // Start is called before the first frame update
    void Start()
    {
        ObstacleSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
