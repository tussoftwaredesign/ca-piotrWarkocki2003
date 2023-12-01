using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script to check if the socket has a correct item attached to it
//Used for the code combination to open main door
public class SocketChecker : MonoBehaviour
{
    
    public GameObject SocketAttach;
    
    void Start()
    {
        //sockets attach game object starts of as false
        SocketAttach.SetActive(false);
    }


    public void OnTriggerEnter(Collider obj)
    {
        /*if the game object is on the correct socket then activate the sockets
        attach game object*/
        if (obj.gameObject.name == "code4" && gameObject.name == "Code4socket" || 
            obj.gameObject.name == "code3" && gameObject.name == "Code3socket" || 
            obj.gameObject.name == "code2" && gameObject.name == "Code2socket" || 
            obj.gameObject.name == "code1" && gameObject.name == "Code1socket")
        {
            SocketAttach.SetActive(true);
            Debug.Log("correct");
        }
        else
        {
            Debug.Log("Wrong Obj");

        }
    }
    public void OnTriggerExit(Collider obj)
    {
        
        SocketAttach.SetActive(false);
    }
}
