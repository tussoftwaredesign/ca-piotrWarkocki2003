using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timeText; // Reference to the TextMeshProUGUI component
    private float currentTime = 0f; // Initial time value
    private bool isTimeRunning = true; // Flag to control whether time should update

    // Update is called once per frame
    void Update()
    {
        // Check if time should continue updating
        if (isTimeRunning)
        {
            // Increase time by one second every frame
            currentTime += Time.deltaTime;

            // Update the TextMeshProUGUI with the current time
            UpdateTimeText();

            // Optionally, you can display the time in the console for testing
            Debug.Log("Current Time: " + FormatTime(currentTime)); // Log the formatted time
        }
    }

    void UpdateTimeText()
    {
        // Ensure there is a reference to the TextMeshProUGUI component
        if (timeText != null)
        {
            // Update the TextMeshProUGUI with the formatted time
            timeText.text = FormatTime(currentTime)+ " Minutes ";
        }
        else
        {
            Debug.LogWarning("TextMeshProUGUI reference is not set in the inspector!");
        }
    }

    string FormatTime(float timeInSeconds)
    {
        int minutes = Mathf.FloorToInt(timeInSeconds / 60f);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60f);

        // Format the time as MM:SS
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Call this method when you want to stop the time
    public void StopTime()
    {
        isTimeRunning = false;
    }
}