﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 300;
    public Text timeText;

    private void Start()
    {
        //Debug.Log("Testing Timer");
    }
    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
        //Debug.Log(timeValue);

    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay <0)
        {
            timeToDisplay = 0;
        }


        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}