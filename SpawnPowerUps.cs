using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Class that spawns power ups after they have been destroyed
/// </summary>
public class SpawnPowerUps : MonoBehaviour
{
    public GameObject[] powerUpCube;        // Power up cubes
    private float LPUDelay = 5;             // Timer for Laser power up
    private float LPUTimer;                 // Keep track of the duration of the Laser power up
    private float SpPUDelay = 5;            // Timer for Speed power up
    private float SpPUTimer;                // Keep track of the duration of the Speed power up
    private float SPUDelay = 5;             // Timer for Size power up
    private float SPUTimer;                 // Keep track of the duration of the Size power up

    /// <summary>
    /// Keep track of whether the power ups are spawned
    /// </summary>
    public Dictionary<string, bool> powerUpSpawned = new Dictionary<string, bool>()
        {
            { "Laser", true},
            { "Speed", true},
            { "Size", true}
        };

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
        //time delay for power ups
        if (powerUpSpawned["Laser"] == false)
        {
            LPUTimer += Time.deltaTime;
            if (LPUTimer > LPUDelay)
            {
                SpawnPowerUp("Laser");
                LPUTimer = 0;
            }
        }

        if (powerUpSpawned["Speed"] == false)
        {
            SpPUTimer += Time.deltaTime;
            if (SpPUTimer > SpPUDelay)
            {
                SpawnPowerUp("Speed");
                SpPUTimer = 0;
            }
        }

        if (powerUpSpawned["Size"] == false)
        {
            SPUTimer += Time.deltaTime;
            if (SPUTimer > SPUDelay)
            {
                SpawnPowerUp("Size");
                SPUTimer = 0;
            }
        }
    }

    /// <summary>
    /// Spawn Power up cubes
    /// </summary>
    public void SpawnPowerUp(string PUType)
    {
        powerUpSpawned[PUType] = true;
        int index = powerUpSpawned.Keys.ToList().IndexOf(PUType);
        powerUpCube[index].SetActive(true);
    }
}
