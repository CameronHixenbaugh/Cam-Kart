using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public PlayerController pc;                 // Vehicle 
    private float speedDelay = 5;               // Timer for speed power up
    private float speedTimer;                   // Keep track of the duration of the speed power up
    private bool powerUpActive = false;         // Speed power up activation

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
        //time delay for power up
        if (powerUpActive)
        {
            speedTimer += Time.deltaTime;
            if (speedTimer > speedDelay)
            {
                RevertSpeedPowerUp();
                speedTimer = 0;
            }
        }
    }

    /// <summary>
    /// Change the color of the vehicle and increase the speed
    /// </summary>
    public void SpeedPowerUp()
    {
        powerUpActive = true;
        GameObject.Find("Player").GetComponent<Renderer>().material.color = new Color(255, 248, 0);
        pc.speed = 100;        
    }

    /// <summary>
    /// Revert the vehicle color and speed
    /// </summary>
    private void RevertSpeedPowerUp()
    {
        powerUpActive = false;
        GameObject.Find("Player").GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        pc.speed = 20;
    }
}
