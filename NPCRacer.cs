using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class controls the NPC Racer
/// </summary>
public class NPCRacer : MonoBehaviour
{
    public StartCountDown scd;      // StartCountDown class
    private float npcSpeed = 39;    // Speed of the NPC racer

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
        if (scd.readyToRace)
        {
            transform.Translate(Vector3.back * Time.deltaTime * npcSpeed);
        }
    }
}
