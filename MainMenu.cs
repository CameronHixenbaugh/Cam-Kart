using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Start").GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        GameObject.Find("Start").GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnMouseExit()
    {
        GameObject.Find("Start").GetComponent<Renderer>().material.color = Color.black;
    }
}
