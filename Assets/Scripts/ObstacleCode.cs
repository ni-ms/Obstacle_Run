using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCode : MonoBehaviour
{
    PlayerMovement playerMovement;


    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
         
            playerMovement.setAlive(false);
   
        }
    }
    
}
