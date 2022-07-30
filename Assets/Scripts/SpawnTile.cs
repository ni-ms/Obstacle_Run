using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTile : MonoBehaviour
{

    public GameObject groundTile;
    public GameObject spawnTile;
    private Vector3 previousTilePosition;
    private float startTime;
    private float distanceBetweenTiles = 1;
    private Vector3 mainDirection = new(0, 0, 1);
    // Start is called before the first frame update
    void Start()
    {
        previousTilePosition = groundTile.transform.position;   
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPos = previousTilePosition + distanceBetweenTiles * mainDirection * 25;
        startTime = Time.time;
        Instantiate(spawnTile, spawnPos, Quaternion.Euler(0, 0, 0));
        previousTilePosition = spawnPos;
        
    }
}
