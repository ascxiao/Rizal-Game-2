using UnityEngine;
using TMPro; 

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 150f; 
    public TextMeshProUGUI timerText;
    private bool timerRunning = true;
    public GameObject GameFailed;

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
                DisplayTime(timeRemaining);
                GameFailed.SetActive(true);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay = Mathf.Max(timeToDisplay, 0);
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("Time Remaining: {0:00}:{1:00}", minutes, seconds);
    }

    public void PauseTimer()
    {
        timerRunning = false;
    }

    public void ResumeTimer()
    {
        timerRunning = true;
    }
}
