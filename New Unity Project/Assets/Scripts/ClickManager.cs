using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace CookieClickerScripts
{


    public class ClickManager : MonoBehaviour
    {
        public TextMeshProUGUI display;
        public static float pets;

        

        public void GetClicks()
        {
            pets += 1;
            Debug.Log("You pet the animal");
        }

        

        private void Update()
        {
            display.text = ("You have " + pets + " Petpoints");
        }
    }
}