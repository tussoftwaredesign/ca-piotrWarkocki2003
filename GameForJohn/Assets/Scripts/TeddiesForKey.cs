using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Script used for storageRoomkey activation by checking if teddies are on bed
public class TeddiesForKey : MonoBehaviour
{
    // this is the storage room key game object
    public GameObject StorageRoomKey;
    // Number of teddies required for key activation.
    public int requiredTeddies = 3; 

    //amount of teddies in the bed at the start
    private int teddiesInBed = 0;


    public void Start()
    {
        //sets key active state to false
       StorageRoomKey.SetActive(false);
    }

    //using trigger events to determine if teddy is on sink
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teddy")) // teddies need "Teddy" Tag
        {
            //number of teddies goes up when trigger happens
            teddiesInBed++;
            //print that the teddy is in bed and print total amount of teddies in bed
            Debug.Log("Teddy entered the bed. TotalTeddies on bed: " + teddiesInBed);

            //set key active state to ON if there is 5 teddies in bed
            if (teddiesInBed >= requiredTeddies)
            {
                StorageRoomKey.SetActive(true);
            }
        }
    }
    //if cup leaves the trigger event...
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Teddy"))
        {
            //number of teddies goes down when teddy leaves trigger event
            teddiesInBed--;
            // print that the teddy left the bed and print total amount of teddies in bed
            Debug.Log("Teddy exited the bed. Total Teddies in bed: " + teddiesInBed);

            if (teddiesInBed < requiredTeddies)
            {
                StorageRoomKey.SetActive(false);
            }
        }
    }
}