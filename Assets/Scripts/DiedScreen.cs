using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiedScreen : MonoBehaviour
{
    PlayerMovement playerMovement;
    public GameObject diedMenuUI;
   
  public void enableScreen()
    {
        diedMenuUI.SetActive(true);
      
    }
    // Start is called before the first frame update
    void Start()
    {
   
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();

        diedMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!playerMovement.alive)
        {
            
            playerMovement.setAlive(false);
            Time.timeScale = 0f;
            
         
        } 
    }
}
