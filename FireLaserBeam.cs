using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaserBeam : MonoBehaviour
{
    private float laserSpeed = 40;  // Laser beam speed

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
        transform.Translate(Vector3.up * Time.deltaTime * laserSpeed);
    }
}
