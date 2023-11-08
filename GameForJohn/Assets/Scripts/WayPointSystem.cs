using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointSystem : MonoBehaviour
{
    public Transform[] waypoints;  // Array of waypoints to follow
    public float moveSpeed = 2.0f; // Speed at which the object moves
    public float rotationSpeed = 5.0f; // Speed at which the object rotates to face the next waypoint
    public float waitTime = 2.0f; // Time to wait at each waypoint

    private int currentWaypointIndex = 0; // Index of the current waypoint
    private float waitTimer = 0.0f; // Timer for waiting at each waypoint
    private bool isWaiting = false; // Flag to indicate if waiting

    void Update()
    {
        // Check if there are waypoints to follow
        if (waypoints.Length == 0)
            return;

        // If not waiting, move towards the current waypoint
        if (!isWaiting)
        {
            Vector3 targetPosition = waypoints[currentWaypointIndex].position;
            Vector3 moveDirection = targetPosition - transform.position;
            Quaternion rotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            // Check if the object has reached the current waypoint
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                // Start waiting at the waypoint
                isWaiting = true;
                waitTimer = 0.0f;
            }
        }
        else
        {
            // Wait at the current waypoint
            waitTimer += Time.deltaTime;
            if (waitTimer >= waitTime)
            {
                // Move to the next waypoint after the wait time is over
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
                isWaiting = false;
            }
        }
    }
}
