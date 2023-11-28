using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Reference to the TimeController script
    public TimeController timeController;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player collides with a door
        if (other.CompareTag("Door"))
        {
            // Call the StopTime method in the TimeController script
            timeController.StopTime();
        }
    }
}