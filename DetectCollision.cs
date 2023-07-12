using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public PowerUps pow;            // Vehicle powewr ups 

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
        pow.SpeedPowerUp();
        Destroy(gameObject);
    }
}
