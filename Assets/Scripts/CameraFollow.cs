using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject groundFollow;
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hoverCam = offset + player.position;
        hoverCam.x = groundFollow.transform.position.x + 2.5f;
        transform.position = hoverCam;
    }
}
