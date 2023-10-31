using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddiesForKey : MonoBehaviour
{
    public GameObject StorareRoomKey;
    public int requiredTeddies = 5; // Number of cups required for key activation.


    private int teddiesInBed = 0;


    public void Start()
    {
       StorareRoomKey.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teddy")) // Assuming the cups have a "Cup" tag.
        {
            teddiesInBed++;
            Debug.Log("Teddy entered the bed. TotalTeddies on bed: " + teddiesInBed);

            if (teddiesInBed >= requiredTeddies)
            {
                StorareRoomKey.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Teddy"))
        {
            teddiesInBed--;
            Debug.Log("Teddy exited the bed. Total Teddies in bed: " + teddiesInBed);

            if (teddiesInBed < requiredTeddies)
            {
                StorareRoomKey.SetActive(false);
            }
        }
    }
}