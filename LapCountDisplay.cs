using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class handles the Lap Count display and the results popup
/// </summary>
public class LapCountDisplay : MonoBehaviour
{
    public GameObject L1;               // GO for Lap 1
    public GameObject L2;               // GO for Lap 2
    public GameObject L3;               // GO for Lap 3
    public GameObject ResultCam;        // GO for Results Cam
    public GameObject RestartButton;    // GO for Results Cam
    public GameObject PlayerCam;        // GO for Player Cam
    public GameObject PlayerVehicle;    // GO for Player Vehicle
    public GameObject NPCVehicle;       // GO for NPC Vehicle
    private float finishTimer = 0;      // Timer to show the finished screen
    private float finishDelay = 3;      // Delay to show the finished screen

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
        UpdateLapCountDisplay();

        if (LapCount.RaceCompleted)
        {
            finishTimer += Time.deltaTime;
            if (finishTimer > finishDelay)
            {
                Debug.Log("Race finished");
                PlayerCam.SetActive(false);
                ResultCam.SetActive(true);
                RestartButton.SetActive(true);
                PlayerVehicle.SetActive(false);
                NPCVehicle.SetActive(false);
                finishTimer = 0;
            }
        }
    }

    /// <summary>
    /// As the racer completes a lap update the Lap Count
    /// </summary>
    private void UpdateLapCountDisplay()
    {

        switch (LapCount.finishLineCount)
        {
            case 1:
                L1.SetActive(false);
                L2.SetActive(true);
                break;
            case 2:
                L2.SetActive(false);
                L3.SetActive(true);
                break;
        }
    }

    /// <summary>
    /// Handles the Restart Button in Unity
    /// </summary>
    public void RestartRace()
    {
        LapCount.ResetLapCount();
        StartCountDown.ResetCountDown();
        //L1.SetActive(true);
        SceneManager.LoadScene(1);
    }
}
