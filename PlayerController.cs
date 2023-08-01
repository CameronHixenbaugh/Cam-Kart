using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that allows the user to control the car
/// </summary>
public class PlayerController : MonoBehaviour
{
    public StartCountDown scd;
    public float speed = 40;            // Speed of vehicle
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
        if (scd.readyToRace) {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            //Moving the vehicle with dir arrows
            transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
            transform.Translate(Vector3.back * Time.deltaTime * speed * forwardInput);
        }
    }
}
