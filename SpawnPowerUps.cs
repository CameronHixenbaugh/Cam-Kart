using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUps : MonoBehaviour
{
    public GameObject powerUpCube;
    private float PUDelay = 5;               // Timer for speed power up
    private float PUTimer;                   // Keep track of the duration of the speed power up
    public bool powerUpSpawned = false;

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
        if (powerUpSpawned)
        {
            PUTimer += Time.deltaTime;
            if (PUTimer > PUDelay)
            {
                SpawnPowerUp();
                PUTimer = 0;
            }
        }
    }

    /// <summary>
    /// Spawn Power up cubes
    /// </summary>
    public void SpawnPowerUp()
    {
        powerUpSpawned = false;
        Vector3 spawnPos = new Vector3(3.15773511f, 1.57839346f, 9.81328392f);
        Instantiate(powerUpCube, spawnPos, powerUpCube.transform.rotation);
    }
}
