using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DogIndex : MonoBehaviour
{
    public GameObject heroObject;
    //public GameObject dogCanvas;
    public GameObject resultCanvas;
    public Text resultText;

    private Vector2 lastPos;
    private Vector2 currentPos;
    public float totalDistance;
    public float totalTime;
    public Image dogCircleImage;
    public Text timer;
    public Text dogText;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        //initial start position, time ,last position
        totalDistance = 0;
        totalTime = 0;
        lastPos = transform.position;
        currentPos = transform.position;
        distance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = transform.position; //update current position
        totalDistance += Vector2.Distance(currentPos, lastPos); //find distance difference between current and privous position
        totalTime += Time.deltaTime; //update time
        lastPos = currentPos; //update current position to last postion in order to regree

        Debug.Log(totalDistance);
        dogCircleImage.fillAmount = totalDistance / 100; //fill UI circle

        dogText.text = ""+(int)totalDistance+"%";
        if (distance >= 100 || timer.text == "0s") { //game over when distance >100
            distance = 100;
            resultCanvas.SetActive(true);
            resultText.text = "Dog mood"+ totalDistance + "%";
        }
    }
}
