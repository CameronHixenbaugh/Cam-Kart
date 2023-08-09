using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles tracking the position the player is in
/// </summary>
public class PositionTracker : MonoBehaviour
{
    public GameObject first;                // GO for 1st
    public GameObject second;               // GO for 2nd
    public static int playerPoisition = 1; // Position of player
    private bool updatePlace;               // Bool to set GO for 1st and 2nd

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
        updatePlace = playerPoisition == 1;

        if (!LapCount.RaceCompleted)
        {
            first.SetActive(updatePlace);
            second.SetActive(!updatePlace);
        }
    }

    /// <summary>
    /// Verify the position of the NPC relative to the player
    /// </summary>
    /// <param name="other">NPC Vehicle</param>
    private void OnTriggerStay(Collider other)
    {
        CheckPosition(gameObject.name);
    }

    /// <summary>
    /// If the NPC is in contact with colliders 1 or 2 then the player is in 2nd place
    /// If the NPC is in contact with colliders 2 and 3 then the player is in 2nd place
    /// If the NPC is in contact with colliders 3 or 4 then the player is in 1st place
    /// </summary>
    /// <param name="position">Collider the NPC is touching</param>
    private void CheckPosition(string position)
    {
        if (position == "PT_1" || position == "PT_2")
        {
            playerPoisition = 2;
        }
        else if (position == "PT_3" || position == "PT_4")
        {
            playerPoisition = 1;
        }
    }
}
