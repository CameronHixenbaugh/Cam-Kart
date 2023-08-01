using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that spawns the laser beams
/// </summary>
public class SpawnLaserBeam : MonoBehaviour
{
    public GameObject laserBeamPrefab;                       // Laser Beam
    //public GameObject vehiclePrefab;                       // Vehicle
    public bool lasersEnabled = false;                       // Bool if the laser power up is active
    //private Vector3 laserOffset = new Vector3(0, 0, 5);      // Offset so laser doesn't spawn in car

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
        // When the user has hit the laser power up and hits the space bar spawn lasers
        if (Input.GetKeyDown(KeyCode.Space) && lasersEnabled)
        {
            //Launch a projectile from player
            //To-do have rotation of car update laser beam
            Instantiate(laserBeamPrefab, transform.position, transform.rotation);
        }
        
    }
}
