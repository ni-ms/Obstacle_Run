using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public float moveSpeed = 5;
    public Rigidbody playerBody;

    private void FixedUpdate()
    {
        Vector3 moveForward = transform.forward * moveSpeed * Time.fixedDeltaTime;
        playerBody.MovePosition(playerBody.position + moveForward);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
