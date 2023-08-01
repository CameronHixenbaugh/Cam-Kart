using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles the waypoints for the NPC
/// </summary>
public class NPCWayPoints_Simple : MonoBehaviour
{
    public GameObject npcRacer;      // NPC Racer
    private string waypoint;         // Way Point name
    private string racer;            // Racer that hits the way point

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
    /// If the NPC racer hits the waypoint rotate the NPC
    /// </summary>
    /// <param name="other">GameObject that hits the waypoint</param>
    private void OnTriggerEnter(Collider other)
    {
        waypoint = gameObject.name;
        racer = other.gameObject.name;

        if (racer == "NPCRacer1")
        {
            switch (waypoint)
            {
                case "WayPoint1":
                case "WayPoint6":
                case "WayPoint11":
                case "WayPoint16":
                    npcRacer.transform.Rotate(0, -18, 0);
                    break;
                case "WayPoint2":
                case "WayPoint7":
                case "WayPoint12":
                case "WayPoint17":
                    npcRacer.transform.Rotate(0, -12, 0);
                    break;
                case "WayPoint3":
                case "WayPoint4":
                case "WayPoint8":
                case "WayPoint9":
                case "WayPoint13":
                case "WayPoint14":
                case "WayPoint18":
                case "WayPoint19":
                    npcRacer.transform.Rotate(0, -15, 0);
                    break;
                case "WayPoint5":
                case "WayPoint10":
                case "WayPoint15":
                case "WayPoint20":
                    npcRacer.transform.Rotate(0, -30, 0);
                    break;
            }
        }
    }
}
