using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddiesForKey : MonoBehaviour
{
    public GameObject StorageRoomKey;
    public int requiredTeddies = 3; // Number of teddies required for key activation.


    private int teddiesInBed = 0;


    public void Start()
    {
       StorageRoomKey.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teddy")) // Assuming the teddies have a "Teddy" tag.
        {
            teddiesInBed++;
            Debug.Log("Teddy entered the bed. TotalTeddies on bed: " + teddiesInBed);

            if (teddiesInBed >= requiredTeddies)
            {
                StorageRoomKey.SetActive(true);
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
                StorageRoomKey.SetActive(false);
            }
        }
    }
}