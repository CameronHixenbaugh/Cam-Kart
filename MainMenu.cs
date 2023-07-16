using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
    /// Handle clicking the Start Button
    /// </summary>
    public void OnStartButton()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Handle clicking the Quit Button
    /// </summary>
    public void OnQuitButton()
    {
        Application.Quit();
    }
}
