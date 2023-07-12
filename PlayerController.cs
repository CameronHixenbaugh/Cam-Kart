using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;            // Speed of vehicle
    private float turnspeed = 70;       // Turn speed of vehicle
    private float horizontalInput;      // right/left directional arrows 
    private float forwardInput;         // Up/down directional arrows

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
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moving the vehicle with dir arrows
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
        transform.Translate(Vector3.back * Time.deltaTime * GetSpeed() * forwardInput);
    }
}
