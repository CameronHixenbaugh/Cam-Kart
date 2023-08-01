using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles the start count down 
/// </summary>
public class StartCountDown : MonoBehaviour
{
    public bool readyToRace = false;        // When the count down has completed the racers may start
    private float countDownTimer;           // Timer to allow racers to start
    private static bool reset = false;      // Reset the countdown
    public GameObject three;                // GO for 3 in Countdown
    public GameObject two;                  // GO for 2 in Countdown
    public GameObject one;                  // GO for 1 in Countdown
    public GameObject go;                   // GO for GO! in Countdown
    public GameObject finishPopUP;          // GO for Finish

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
        countDownTimer += Time.deltaTime;

        if (countDownTimer >= 1.5f && countDownTimer < 3)
        {
            three.SetActive(true);
        }

        if (countDownTimer >= 3 && countDownTimer < 4.5f)
        {
            three.SetActive(false);
            two.SetActive(true);
        }

        if (countDownTimer >= 4.5f && countDownTimer < 6)
        {
            two.SetActive(false);
            one.SetActive(true);
        }

        if (countDownTimer >= 6 && countDownTimer < 7)
        {
            one.SetActive(false);
            go.SetActive(true);
            readyToRace = true;
        }

        if (countDownTimer >= 7)
        {
            go.SetActive(false);
        }

        if (LapCount.RaceCompleted)
        {
            finishPopUP.SetActive(true);
        }

        if (reset)
        {
            reset = false;
            finishPopUP.SetActive(false);
            countDownTimer = 0;
        } 
    }

    /// <summary>
    /// Reset the count down
    /// </summary>
    public static void ResetCountDown()
    {
        reset = true;
    }

}
