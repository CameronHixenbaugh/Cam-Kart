using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that handles all of the power ups
/// </summary>
public class PowerUps : MonoBehaviour
{
    public PlayerController pc;                 // Vehicle 
    public SpawnLaserBeam slb;                  // Spawn Laser beam script 
    private float speedDelay = 5;               // Timer for speed power up
    private float speedTimer;                   // Keep track of the duration of the speed power up
    private float sizeDelay = 5;                // Timer for size power up
    private float sizeTimer;                    // Keep track of the duration of the size power up
    private float laserDelay = 5;               // Timer for laser power up
    private float laserTimer;                   // Keep track of the duration of the laser power up
    private bool speedPowerUpActive = false;    // Speed power up activation
    private bool sizePowerUpActive = false;     // Size power up activation
    private bool laserPowerUpActive = false;    // Laser power up activation

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
        //To-Do create a method to handle the timers in a cleaner way 
        //time delay for speed power up
        if (speedPowerUpActive)
        {
            speedTimer += Time.deltaTime;
            if (speedTimer > speedDelay)
            {
                RevertSpeedPowerUp();
                speedTimer = 0;
            }
        }

        //time delay for size power up
        if (sizePowerUpActive)
        {
            sizeTimer += Time.deltaTime;
            if (sizeTimer > sizeDelay)
            {
                RevertSizePowerUp();
                sizeTimer = 0;
            }
        }

        //time delay for laser power up
        if (laserPowerUpActive)
        {
            laserTimer += Time.deltaTime;
            if (laserTimer > laserDelay)
            {
                RevertLaserPowerUp();
                laserTimer = 0;
            }
        }
    }

    /// <summary>
    /// Change the color of the vehicle and increase the speed
    /// </summary>
    public void SpeedPowerUp()
    {
        speedPowerUpActive = true;
        GameObject.Find("Player").GetComponent<Renderer>().material.color = new Color(255, 248, 0);
        pc.speed = 80;        
    }

    /// <summary>
    /// Change the scale of the vehicle
    /// </summary>
    public void SizePowerUp()
    {
        sizePowerUpActive = true;
        GameObject.Find("Player").transform.localScale = new Vector3(3, 3, 3);
    }

    /// <summary>
    ///  Allow vehicle to fire laser beams
    /// </summary>
    public void LaserPowerUp()
    {
        laserPowerUpActive = true;
        slb.lasersEnabled = true;
    }

    /// <summary>
    ///  Disable Laser beams
    /// </summary>
    public void RevertLaserPowerUp()
    {
        laserPowerUpActive = false;
        slb.lasersEnabled = false;
    }

    /// <summary>
    /// Revert the vehicle color and speed
    /// </summary>
    private void RevertSpeedPowerUp()
    {
        speedPowerUpActive = false;
        GameObject.Find("Player").GetComponent<Renderer>().material.color = new Color(0, 0, 255);
        pc.speed = 40;
    }

    /// <summary>
    /// Revert the scale of the vehicle
    /// </summary>
    public void RevertSizePowerUp()
    {
        sizePowerUpActive = false;
        GameObject.Find("Player").transform.localScale = new Vector3(1, 1, 1);
    }
}
