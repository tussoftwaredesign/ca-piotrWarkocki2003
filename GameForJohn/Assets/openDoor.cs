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

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Collider>().tag == "15A")
        {
            doorBedroom15A.SetActive(false);
            key15A.SetActive(false);
        }

        if (other.GetComponent<Collider>().tag == "15B")
        {
            doorBedroom15B.SetActive(false);
            key15B.SetActive(false);
        }


        if (other.GetComponent<Collider>().tag == "storageDoor")
        {
            doorStorageRoom.SetActive(false);
            keyStorage.SetActive(false);
        }

        if (other.GetComponent<Collider>().tag == "livingRoomDoor")
        {
            doorLivingRoom.SetActive(false);
            keyLivingRoom.SetActive(false);
        }

        if (other.GetComponent<Collider>().tag == "boilerDoor")
        {
            doorBoilerRoom.SetActive(false);
            keyBoilerRoom.SetActive(false);
        }


    }
}
