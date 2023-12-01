using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Script used to toggle items on and off
//script attached to objects such as lights and then handled in 
//activatiion events of the object
public class toggleONOFF : MonoBehaviour
{
    
    public void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
