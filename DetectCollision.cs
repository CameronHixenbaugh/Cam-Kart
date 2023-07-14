using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public PowerUps pow;            // Vehicle power ups
    public SpawnPowerUps spu;
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
        //Activate the speed power up
        cubeType = gameObject.name;
        switch (cubeType)
        {
            case "SpeedCube":
                pow.SpeedPowerUp();
                break;
            case "SizeCube":
                pow.SizePowerUp();
                break;
            case "LaserCube":
                Debug.Log("laser");
                break;
        }

        //spu.powerUpSpawned = true;
        Destroy(gameObject);
    }
}
