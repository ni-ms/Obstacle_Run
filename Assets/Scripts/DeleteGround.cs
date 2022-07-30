using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteGround : MonoBehaviour
{
    SpawnTile groundSpawner;
    // Start is called before the first frame update
    void Start()
    {
     groundSpawner = GameObject.FindObjectOfType<SpawnTile>();     
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
