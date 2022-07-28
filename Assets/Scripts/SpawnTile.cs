using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTile : MonoBehaviour
{
    public GameObject tileToSpawn;
    public GameObject prevTile;
    public float distanceBetweenTiles = 0f;
    public float randomVal = 0.8f;
    public float timeOffset = 0.4f;
    private Vector3 previousTilePosition;
    private float startTime;
    private Vector3 direction, mainDirection = new Vector3(0, 0, 1), nextDirection = new Vector3(1, 0, 0); 
    // Start is called before the first frame update
    void Start()
    {
        previousTilePosition = prevTile.transform.position;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - startTime > timeOffset)
        {
            if(Random.value < randomVal)
            {
                direction = mainDirection;
            }
            else
            {
                Vector3 temp = direction;
                direction = nextDirection;
                mainDirection = direction;
                nextDirection = temp;
            }
            Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction;
            startTime = Time.time;
            Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
            previousTilePosition = spawnPos;
        }
        
    }
}
