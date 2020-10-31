using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float intialTime;
    public float currentTime;
    public Text timeDisplay;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = intialTime;
        timeDisplay.text = intialTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        timeDisplay.text = ((int)currentTime).ToString()+"s";

    }
}
