using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMainDoor : MonoBehaviour
{
    //calls the TimeController script
    public TimeController timeController;

    //gameobjects to determine the door that will be opened
    public GameObject door;

    //sockets used to open the door
    public GameObject attach1Socket;

    public GameObject attach2Socket;

    public GameObject attach3Socket;

    public GameObject attach4Socket;
    

    void Start()
    {
        //door starts off as visible
        door.SetActive(true);
    }

    
    void Update()
    {
        //if all sockets are turned to active then call the mainDoorCoolDown class with a Coroutine
        if (attach1Socket.activeSelf && attach2Socket.activeSelf && attach3Socket.activeSelf && attach4Socket.activeSelf)
        {
            StartCoroutine(mainDoorCoolDown(1f));
            Debug.Log("Attach active ");
        }
        else
        {
            door.SetActive(true);
        }
    }

    IEnumerator mainDoorCoolDown(float waitTime)
    {
        //wait for amount of seconds determined to open door and then open it
        yield return new WaitForSeconds(waitTime);
        //set doors state to false
        door.SetActive(false);
        //stop the time in the TimeController script
        timeController.StopTime();
    }
}
