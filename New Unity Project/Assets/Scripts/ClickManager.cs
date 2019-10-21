using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour
{
    public static int pets;
    public TextMeshProUGUI display;

    public void GetClicks()
    {
        pets += 1;
        
    }

    private void Update()
    {
        display.text = ("You have " + pets + " Petpoints");
    }
}
