using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMainDoor : MonoBehaviour
{
    public GameObject door;

    public GameObject attach1Socket;

    public GameObject attach2Socket;

    public GameObject attach3Socket;

    public GameObject attach4Socket;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (attach1Socket.activeSelf && attach2Socket.activeSelf && attach3Socket.activeSelf && attach4Socket.activeSelf)
        {
            StartCoroutine(mainDoorCoolDown(1f));
        }
        else
        {
            door.SetActive(true);
        }
    }

    IEnumerator mainDoorCoolDown(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        door.SetActive(false);
    }
}
