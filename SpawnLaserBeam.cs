using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLaserBeam : MonoBehaviour
{
    public GameObject laserBeamPrefab;
    public bool LasersEnabled = false;
    private Vector3 laserOffset = new Vector3(0, 0, 5);

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
        if (Input.GetKeyDown(KeyCode.Space) && LasersEnabled)
        {
            //Launch a projectile from player
            //To-do have rotation of car update laser beam
            Instantiate(laserBeamPrefab, transform.position + laserOffset, laserBeamPrefab.transform.rotation);
        }
    }
}
