using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;
public class openDoor : MonoBehaviour
{

    public GameObject doorBedroom15A;
    public GameObject key15A;

    public GameObject doorBedroom15B;
    public GameObject key15B;

    public GameObject doorStorageRoom;
    public GameObject keyStorage;
    
    public GameObject doorLivingRoom;
    public GameObject keyLivingRoom;
    
    public GameObject doorBoilerRoom;
    public GameObject keyBoilerRoom;

    public GameObject doorOutside;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "15A")
        {
            doorBedroom15A.SetActive(false);
            key15A.SetActive(false);
        }

        if (collision.collider.tag == "15B")
        {
            doorBedroom15B.SetActive(false);
            key15B.SetActive(false);
        }


        if (collision.collider.tag == "storageDoor")
        {
            doorStorageRoom.SetActive(false);
            keyStorage.SetActive(false);
        }

        if (collision.collider.tag == "livingRoomDoor")
        {
            doorStorageRoom.SetActive(false);
            keyLivingRoom.SetActive(false);
        }

        if (collision.collider.tag == "boilerDoor")
        {
            doorStorageRoom.SetActive(false);
            keyBoilerRoom.SetActive(false);
        }


    }
}
