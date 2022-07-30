using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public bool alive = true;
    public float moveSpeed = 1;
    public Rigidbody playerBody;
    public float horizontalSpeed = 0.5f;
    float horizontalInput;

    public DiedScreen diedScreen;
 
    private void FixedUpdate()
    {
        Vector3 moveForward = transform.forward * moveSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = horizontalSpeed * transform.right * horizontalInput * moveSpeed * Time.fixedDeltaTime;
        playerBody.MovePosition(playerBody.position + moveForward + horizontalMove);
    }
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (!alive)
        {
            
            diedScreen.enableScreen();
            alive = false;
            Time.timeScale = 0.0f;
        }
    }
    public bool getAlive()
    {
        return alive;
    }
    public void setAlive(bool val)
    {
        alive = val;
    }
  
   
}
