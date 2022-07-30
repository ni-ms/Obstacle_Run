using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 5;
    public Rigidbody playerBody;

    float horizontalInput;
    float horizontalSpeed = 2;
    private void FixedUpdate()
    {
        Vector3 moveForward = transform.forward * moveSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = horizontalSpeed * transform.right * horizontalInput * moveSpeed * Time.fixedDeltaTime;
        playerBody.MovePosition(playerBody.position + moveForward + horizontalMove);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");   
    }
}
