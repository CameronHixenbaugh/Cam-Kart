using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that controls the laser beams
/// </summary>
public class FireLaserBeam : MonoBehaviour
{
    private float laserSpeed = 90;                  // Laser beam speed
    private float topBound = 250;                   // Top Bound of Map
    private float bottomBound = -250;               // Bottom Bound of Map
    private float rightBound = 250;                 // Right Bound of Map
    private float leftBound = -250;                 // Left Bound of Map
                                                     
    private bool topBoundTriggered = false;         // Has the laser beam crossed the top bound
    private bool bottomBoundTriggered = false;      // Has the laser beam crossed the bottom bound
    private bool rightBoundTriggered = false;       // Has the laser beam crossed the right bound
    private bool leftBoundTriggered = false;        // Has the laser beam crossed the left bound

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
        // Move the laser beam forward when fired
        transform.Translate(Vector3.up * Time.deltaTime * laserSpeed);

        // Destroy Laser beam when it leaves the map bounds
        DestroyLasersOutOfRange();
    }

    /// <summary>
    /// Destroy lasers if they leave the map bounds
    /// </summary>
    private void DestroyLasersOutOfRange()
    {
        topBoundTriggered = transform.position.z > topBound;
        bottomBoundTriggered = transform.position.z < bottomBound;
        rightBoundTriggered = transform.position.x > rightBound;
        leftBoundTriggered = transform.position.x < leftBound;

        if (topBoundTriggered || bottomBoundTriggered || rightBoundTriggered || leftBoundTriggered)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// If the laser beam hits an object destroy the beam
    /// </summary>
    /// <param name="other">Game Object that touches the laser beam</param>
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
