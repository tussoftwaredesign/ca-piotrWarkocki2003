using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketChecker : MonoBehaviour
{
    public GameObject SocketAttach;
    // Start is called before the first frame update
    void Start()
    {
        SocketAttach.SetActive(false);
    }

 
    

    public void OnTriggerEnter(Collider obj)
    {
        
        if (obj.gameObject.name == "code4" && gameObject.name == "Code4socket" || obj.gameObject.name == "code3" && gameObject.name == "Code3socket"
           || obj.gameObject.name == "code2" && gameObject.name == "Code2socket" || obj.gameObject.name == "code1" && gameObject.name == "Code1socket")
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
