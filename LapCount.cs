using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class tracks how many laps have been completed
/// </summary>
public class LapCount : MonoBehaviour
{
    public static int finishLineCount = 0;      // Count how many times the player crosses finsh line
    private static bool CP1 = false;            // Check Point 1
    private static bool CP2 = false;            // Check Point 2
    private static bool CP3 = false;            // Check Point 3
    public static bool RaceCompleted = false;   // Is the race finished

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
        if (finishLineCount == 3)
        {
            RaceCompleted = true;
        }
    }

    /// <summary>
    /// When the player hits a check point mark it as true.
    /// when all check points have been hit and the player crosses the finish line
    /// update "finishLine" +1 and reset all check points to false 
    /// </summary>
    /// <param name="other">Player's vehicle</param>
    private void OnTriggerEnter(Collider other)
    {
        switch (gameObject.name)
        {
            case "Finish":
                if (CP1 && CP2 && CP3)
                {
                    finishLineCount++;
                    CP1 = false;
                    CP2 = false;
                    CP3 = false;
                }
                    break;
            case "CheckPoint1":
                CP1 = true;
                break;
            case "CheckPoint2":
                CP2 = true;
                break;
            case "CheckPoint3":
                CP3 = true;
                break;
        }
    }

    /// <summary>
    /// Reset the Lap Count
    /// </summary>
    public static void ResetLapCount()
    {
        CP1 = false;
        CP2 = false;
        CP3 = false;
        finishLineCount = 0;
        RaceCompleted = false;
    }
}
