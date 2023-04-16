using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 1500f; // 25 minutes in seconds
    private TextMeshProUGUI textMeshProUGUI;

    void Start()
    {
        // Get a reference to the TextMeshProUGUI component
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Subtract Time.deltaTime from the timeRemaining variable
        timeRemaining -= Time.deltaTime;

        // Convert the remaining time to minutes and seconds
        float minutes = Mathf.FloorToInt(timeRemaining / 60f);
        float seconds = Mathf.FloorToInt(timeRemaining % 60f);

        // Update the TextMeshProUGUI component with the new time
        textMeshProUGUI.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
