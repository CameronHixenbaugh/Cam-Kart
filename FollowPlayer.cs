using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that makes the camera follow the user
/// </summary>
public class FollowPlayer : MonoBehaviour
{
    private Vector3 cameraOffset = new Vector3(0, 2, 6);    //Camera Offset
    private float horizontalInput;                          //Left/right directional arrows
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // Have the camera follow the vehicle
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput);
        transform.localPosition = cameraOffset;
    }
}
