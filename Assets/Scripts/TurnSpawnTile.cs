using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSpawnTile : MonoBehaviour
{
    public GameObject tileToSpawn;
    public GameObject tileToSpawnTurn;
    public GameObject referenceObject;
    public float timeOffset = 0.01f;
    public float distanceBetweenTiles = 0.0F;
    public float randomValue = 0.5f;
    private Vector3 previousTilePosition;
    private float startTime;
    private Vector3 direction, mainDirection = new Vector3(0, 0, 1), otherDirection = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        previousTilePosition = referenceObject.transform.position;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > timeOffset)
        {
            if (Random.value < randomValue)
                direction = mainDirection;
            else
            {
                Vector3 temp = direction;
                direction = otherDirection;
                mainDirection = direction;
                otherDirection = temp;
            }
            Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * direction * 50;
            startTime = Time.time;
            if(direction == new Vector3(0,0,1))
            Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
            else if(direction == new Vector3(0, 1, 0) || direction == new Vector3(1, 0, 0))
            {
                
                Instantiate(tileToSpawnTurn, spawnPos, Quaternion.Euler(0, 270, 0));
                if(direction == previousTilePosition)
                Instantiate(tileToSpawn, spawnPos, Quaternion.Euler(0, 0, 0));
            }
            
            previousTilePosition = spawnPos;
        } 
    }
}
