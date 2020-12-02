using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float intialTime;
    public float currentTime;
    public Text timeDisplay;
    public GameObject resultsCanvas; //check out canvas


    // Start is called before the first frame update
    void Start()
    {
        currentTime = intialTime; //initial game time 
        timeDisplay.text = intialTime.ToString();
    }
    //timer update each frame
    void Update()
    {
        currentTime -= Time.deltaTime; //remaining time
        timeDisplay.text = ((int)currentTime).ToString()+"s";
        if (currentTime <= 0) {
            resultsCanvas.SetActive(true); //if remainig time less than 0, game end 
            currentTime = 0;
        }
        if(currentTime < 10) //if there is less than 10s, text will change color
        {
            timeDisplay.color = Color.red;
        }
    }
}
