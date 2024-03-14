using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerLabel;
    public float startTimer;
    private bool finished = false;

    void Start() 
    {
        startTimer = Time.time;
    }
    void Update()
    {
        if(finished) 
            return;

        float t = Time.time - startTimer;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerLabel.text = minutes + ":" + seconds;
    }
    public void Finish()
    {
        finished = true;
        timerLabel.color = Color.yellow;
    }
}
