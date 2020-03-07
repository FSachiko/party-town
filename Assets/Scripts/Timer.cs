﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

    public Image timeBar;
    public float maxTime = 10f;
    public float timeLeft;


    // Start is called before the first frame update
    void Start() {
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update() {
        if (timeLeft > 0) {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / maxTime;
        } else {

        }
    }

    public void ResetTimer() {
        timeLeft = 10f;
    }
}
