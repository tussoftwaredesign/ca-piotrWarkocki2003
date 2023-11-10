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

    public GameObject CodeSocket1;
    public GameObject CodeSocket2;
    public GameObject CodeSocket3;
    public GameObject CodeSocket4;

    public GameObject Number1;
    public GameObject Number2;
    public GameObject Number3;
    public GameObject Number4;

    public void Start()
    {

        CodeSocket1.SetActive(false);
        CodeSocket2.SetActive(false);
        CodeSocket3.SetActive(false);
        CodeSocket4.SetActive(false);
        Number1.SetActive(false);
        Number2.SetActive(false);
        Number3.SetActive(false);
        Number4.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.GetComponent<Collider>().tag;

        switch (tag)
        {
            case "15A":
                doorBedroom15A.SetActive(false);
                key15A.SetActive(false);
                break;

            case "15B":
                doorBedroom15B.SetActive(false);
                key15B.SetActive(false);
                break;

            case "storageDoor":
                doorStorageRoom.SetActive(false);
                keyStorage.SetActive(false);
                break;

            case "livingRoomDoor":
                doorLivingRoom.SetActive(false);
                keyLivingRoom.SetActive(false);
                break;

            case "boilerDoor":
                doorBoilerRoom.SetActive(false);
                keyBoilerRoom.SetActive(false);
                CodeSocket1.SetActive(true);
                CodeSocket2.SetActive(true);
                CodeSocket3.SetActive(true);
                CodeSocket4.SetActive(true);
                Number1.SetActive(true);
                Number2.SetActive(true);
                Number3.SetActive(true);
                Number4.SetActive(true);
                break;

            default:
                // Handle other cases if needed
                break;
        }
    }
}
