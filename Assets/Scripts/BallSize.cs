using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSize : MonoBehaviour
{
    public GameObject playerSphere;
    public Dropdown playerSize;
    private float size = 1.0f;

    public void ChangeSize()
    {
        if(playerSize.value == 1)
        {
            size = 1.0f;
        }
        else if(playerSize.value == 2)
        {
            size = 2.0f;
        }
        else if(playerSize.value == 3)
        {
            size = 3.0f;
        }
        else
        {
            size = 1.0f; //Keeps size defaulted to 1 if no selection is chosen
        }

        playerSphere.transform.localScale = new Vector3(size, size, size); //Change player sphere scale with new size value
        
        playerSphere.transform.localPosition = new Vector3(playerSphere.transform.localPosition.x, 0.5f * size, playerSphere.transform.localPosition.z); // adjust vertical position so ball does not end up in or above the plane
    }
}