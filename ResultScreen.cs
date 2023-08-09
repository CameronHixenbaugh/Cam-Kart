using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles the results screen when the race ends.
/// </summary>
public class ResultScreen : MonoBehaviour
{
    private float finishTimer = 0;      // Timer to show the finished screen
    private float finishDelay = 3;      // Delay to show the finished screen
    private bool playerPos = false;     // bool for position GO
    public GameObject firstPlace;       // GO 1st place
    public GameObject secondPlace;      // GO 2nd place
    public GameObject L3;               // GO for Lap 3
    public GameObject ResultCam;        // GO for Results Cam
    public GameObject RestartCanvas;    // GO for Results Canvas
    public GameObject PlayerCam;        // GO for Player Cam
    public GameObject PlayerVehicle;    // GO for Player Vehicle
    public GameObject NPCVehicle;       // GO for NPC Vehicle
    public GameObject CountDown;        // GO for Finished Popup
    public GameObject PlaceDisplay;     // GO for Position
    public GameObject LapTitle;         // GO for Lap title
    public GameObject TotalLaps;        // GO for total laps

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
        if (LapCount.RaceCompleted)
        {
            finishTimer += Time.deltaTime;
            if (finishTimer > finishDelay)
            {
                PlayerCam.SetActive(false);
                CountDown.SetActive(false);
                PlaceDisplay.SetActive(false);
                LapTitle.SetActive(false);
                L3.SetActive(false);
                TotalLaps.SetActive(false);
                PlayerVehicle.SetActive(false);
                NPCVehicle.SetActive(false);
                ResultCam.SetActive(true);
                RestartCanvas.SetActive(true);
                finishTimer = 0;
                playerPos = PositionTracker.playerPoisition == 1;
                firstPlace.SetActive(playerPos);
                secondPlace.SetActive(!playerPos);
            }
        }
    }
}
