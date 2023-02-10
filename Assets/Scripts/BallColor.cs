
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallColor : MonoBehaviour
{
    public Dropdown ColorDropdown;
    public GameObject playerSphere;
    void Start()
    {
        playerSphere.GetComponent<Renderer>().material.color = Color.white;
    }

    public void ChooseColor()
    {
        switch (ColorDropdown.value)
        {
            case 1:
                playerSphere.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                playerSphere.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 3:
                playerSphere.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 4:
                playerSphere.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 5:
                playerSphere.GetComponent<Renderer>().material.color = Color.white;
                break;
            case 6:
                playerSphere.GetComponent<Renderer>().material.color = Color.magenta;
                break;
            default:
                playerSphere.GetComponent<Renderer>().material.color = Color.white;
                break;
        }
    }
}