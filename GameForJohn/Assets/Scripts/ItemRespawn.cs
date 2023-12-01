using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Script attached to all grabbable objects in game...
/*Respawns grabbables to their original starting position if
 objects fall out of the map and hit the RespawnCollider*/

public class ItemRespawn : MonoBehaviour
{
    // Store the initial position of the object
    private Vector3 initialPosition;

    void Start()
    {
        // Save the initial position when the script starts
        initialPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        // Checks if the object has collided with a collider 
        if (other.CompareTag("RespawnCollider"))
        {
            // Respawn the object at its initial position
            Respawn();
        }
    }

    // Function to respawn the object at its initial position
    void Respawn()
    {
        // Set the object's position to the initial position
        transform.position = initialPosition;

        //resets velocity and rotation 
        if (GetComponent<Rigidbody>() != null)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
