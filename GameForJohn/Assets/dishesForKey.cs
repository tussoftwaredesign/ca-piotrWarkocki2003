using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class dishesForKey : MonoBehaviour
{
    public GameObject Bedroom15AKey;
    public GameObject CodeSocket1;
    public GameObject CodeSocket2;
    public GameObject CodeSocket3;
    public GameObject CodeSocket4;
    public int requiredCups = 5; // Number of cups required for key activation.


    private int cupsInSink = 0;


    public void Start()
    {
        Bedroom15AKey.SetActive(false);
        CodeSocket1.SetActive(false);
        CodeSocket2.SetActive(false);
        CodeSocket3.SetActive(false);
        CodeSocket4.SetActive(false);

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
                CodeSocket1.SetActive(true);
                CodeSocket2.SetActive(true);
                CodeSocket3.SetActive(true);
                CodeSocket4.SetActive(true);
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
                CodeSocket1.SetActive(false);
                CodeSocket2.SetActive(false);
                CodeSocket3.SetActive(false);
                CodeSocket4.SetActive(false);
            }
        }
    }
}
