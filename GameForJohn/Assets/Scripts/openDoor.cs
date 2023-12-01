using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
//script used to open doors in the game
public class openDoor : MonoBehaviour
{
    //public game objects for each key and its corresponding bedroom Door
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

    //socket meshrenders for main door lock code
    public MeshRenderer socket1;
    public MeshRenderer socket2;
    public MeshRenderer socket3;
    public MeshRenderer socket4;
    public GameObject Number1;
    public GameObject Number2;
    public GameObject Number3;
    public GameObject Number4;
    public GameObject ui;

    public void Start()
    {
        //start game with sockets set to false
        socket1.enabled = false;
        socket2.enabled = false;
        socket3.enabled = false;
        socket4.enabled = false;
        Number1.SetActive(false);
        Number2.SetActive(false);
        Number3.SetActive(false);
        Number4.SetActive(false);
        ui.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.GetComponent<Collider>().tag;
        /*if correct key is triggered with the correct door 
         then set both active states to off(open door)*/
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
                /*when boiler room key opens the boiler room then it also 
                enables the sockets and UI to to tell player what to do with codes*/
            case "boilerDoor":
                doorBoilerRoom.SetActive(false);
                keyBoilerRoom.SetActive(false);
                
                socket1.enabled = true;
                socket2.enabled = true;
                socket3.enabled = true;
                socket4.enabled = true;
                Number1.SetActive(true);
                Number2.SetActive(true);
                Number3.SetActive(true);
                Number4.SetActive(true);
                ui.SetActive(true);
                break;

            default:
                // Handle other cases if needed
                break;
        }
    }
}
