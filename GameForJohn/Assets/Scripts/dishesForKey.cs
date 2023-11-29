using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class dishesForKey : MonoBehaviour
{
    public GameObject Bedroom15AKey;
    public int requiredCups = 5; // Number of cups required for key activation.
    private int cupsInSink = 0;

    // Add an AudioSource variable
    

    private void Start()
    {
        Bedroom15AKey.SetActive(false);

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cup")) // Assuming the cups have a "Cup" tag.
        {
            cupsInSink++;
            Debug.Log("Cup entered the sink. Total cups in sink: " + cupsInSink);
            

            

            if (cupsInSink >= requiredCups)
            {
                Bedroom15AKey.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cup"))
        {
            cupsInSink--;
            Debug.Log("Cup exited the sink. Total cups in sink: " + cupsInSink);

            if (cupsInSink < requiredCups)
            {
                Bedroom15AKey.SetActive(false);
            }
        }
    }
}
