using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
//Script for dish functionality...
//5 Cups required in Sink to obtain key object
public class dishesForKey : MonoBehaviour
{
    //bedroom key game object
    public GameObject Bedroom15AKey;
    // Number of cups required for key activation.
    public int requiredCups = 5; 
    //starting number of cups in sink
    private int cupsInSink = 0;

    private void Start()
    {
        //start the game with the keys active state being turned off
        Bedroom15AKey.SetActive(false);
    }
    //using trigger events to determine if cup is in sink
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cup"))//cups need "Cup" Tag
        {
            //number of cups goes up when trigger happens
            cupsInSink++;
            //print that the cup is in sink and print total amount of cups in sink
            Debug.Log("Cup entered the sink. Total cups in sink: " + cupsInSink);
            
            //set key active state to ON if there is 5 cups in sink
            if (cupsInSink >= requiredCups)
            {
                Bedroom15AKey.SetActive(true);
            }
        }
    }
    //if cup leaves the trigger event...
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cup"))
        {
            //number of cups goes down when cup leaves trigger event
            cupsInSink--;
            // print that the cup left the sink and print total amount of cups in sink
            Debug.Log("Cup exited the sink. Total cups in sink: " + cupsInSink);

            //set key active state to OFF if there is not 5 cups in sink
            if (cupsInSink < requiredCups)
            {
                Bedroom15AKey.SetActive(false);
            }
        }
    }
}
