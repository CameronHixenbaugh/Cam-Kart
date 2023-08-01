using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that handles the collision of the power up cubes
/// </summary>
public class PowerUpCollision : MonoBehaviour
{
    public PowerUps pow;            // Vehicle power ups
    public SpawnPowerUps spu;       // Spawn power ups
    private string cubeType;        // Type of cube power up

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
        
    }

    /// <summary>
    /// Activate power up upon collision of cube
    /// </summary>
    /// <param name="other">Game Object that touches the cube(vehicle)</param>
    private void OnTriggerEnter(Collider other)
    {
        // Disable the power up box only if the user hits it
        if (other.gameObject.name == "Player") {
            cubeType = gameObject.name;
            // Activate power ups
            switch (cubeType)
            {
                case "SpeedCube":
                    spu.powerUpSpawned["Speed"] = false;
                    pow.SpeedPowerUp();
                    break;
                case "SizeCube":
                    spu.powerUpSpawned["Size"] = false;
                    pow.SizePowerUp();
                    break;
                case "LaserCube":
                    spu.powerUpSpawned["Laser"] = false;
                    pow.LaserPowerUp();
                    break;
            }

            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
