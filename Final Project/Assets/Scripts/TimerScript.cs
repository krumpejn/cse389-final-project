using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI timerText;
    private float seconds;
    private int minutes;
    void Update()
    {
        UpdateTimerUI();
    }
    //call this on update
    public void UpdateTimerUI()
    {
        //set timer UI
        seconds += Time.deltaTime;
        timerText.text = "Time Elapsed: " + minutes + ":";
        if(seconds < 10)
        {
            timerText.text += "0";
        }
        timerText.text += (int)seconds;
        if (seconds >= 60)
        {
            minutes++;
            seconds = 0;
        }
    }
}
