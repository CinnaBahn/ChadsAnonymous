using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeScore;
    public float startTime;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        timeScore = 0.0f;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timeScore += Time.deltaTime;
        scoreText.text = timeScore.ToString("0");
    }

    public void stopTime()
    {

    }
}

