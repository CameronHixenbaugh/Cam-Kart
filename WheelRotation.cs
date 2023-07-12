using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    private float horizontalInput;        // Left/right directional arrows
    private float verticalInput;          // Up/down directional buttons
    private float wheelSpeed;             // Speed of the wheels
    private float maxWheelSpeed = 5;      // Maximum speed of the wheels
    private float wheelTurn;              // Angle the wheels should turn at
    private float maxWheelTurn = 35;      // Maximum angle the wheels should turn at
    public GameObject frontWheelL;        // Front Left wheel of vehicle
    public GameObject frontWheelR;        // Front Right wheel of vehicle
    public GameObject backWheelL;         // Back Left wheel of vehicle
    public GameObject backWheelR;         // Back Right wheel of vehicle

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
        verticalInput = Input.GetAxis("Vertical");

        // Rotate the wheel back/forth based on user input
        // To-Do make front wheels spin
        wheelSpeed = verticalInput != 0 ? verticalInput * maxWheelSpeed : 0;
        //frontWheelR.transform.Rotate(Vector3.back * wheelSpeed);
        backWheelR.transform.Rotate(Vector3.back * wheelSpeed);
        frontWheelL.transform.Rotate(Vector3.forward * wheelSpeed);
        backWheelL.transform.Rotate(Vector3.forward * wheelSpeed);

        // Turn wheels based on user input
        wheelTurn = horizontalInput != 0 ? horizontalInput * maxWheelTurn : 0;
        //Quaternion target = Quaternion.Euler(0, wheelTurn, 0);
        if (wheelTurn != 0) {
            frontWheelL.transform.localRotation = Quaternion.Euler(0, -90 + wheelTurn, 0);
            frontWheelR.transform.localRotation = Quaternion.Euler(0, 90 + wheelTurn, 0);
        }
        else
        {
            frontWheelL.transform.localRotation = Quaternion.Euler(0, -90, 0);
            frontWheelR.transform.localRotation = Quaternion.Euler(0, 90, 0);
        }

    }
}
