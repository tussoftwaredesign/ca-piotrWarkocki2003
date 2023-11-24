
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        // Check if the object has collided with a collider (you can customize this condition)
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

        // You can also reset other properties like velocity, rotation, etc., if needed
        if (GetComponent<Rigidbody>() != null)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
