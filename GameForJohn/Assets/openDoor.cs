using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;
public class openDoor : MonoBehaviour
{

    public GameObject doorBedroom15A;

    public GameObject doorBedroom15B;

    public GameObject doorStorageRoom;

    public GameObject doorLivingRoom;

    public GameObject doorBoilerRoom;

    public GameObject doorOutside;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "bedroom15aDoor")
        {
            doorBedroom15A.SetActive(false);
        }

        if (collision.collider.tag == "bedroom15bDoor")
        {
            doorBedroom15B.SetActive(false);
        }


        if (collision.collider.tag == "storageDoor")
        {
            doorStorageRoom.SetActive(false);
        }


    }
}
