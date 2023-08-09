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
