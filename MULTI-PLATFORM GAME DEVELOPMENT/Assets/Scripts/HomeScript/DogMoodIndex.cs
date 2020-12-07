using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogMoodIndex : MonoBehaviour
{
    public Image dogImg; //load fridge image
    public Text dogIndexText;
    public static int dogIndex = 80; //inital fridge index
    float percentage;

    // Start is called before the first frame update
    void Start()
    {
        percentage = DogIndex.totalDistance;
        dogIndex = (int)(dogIndex + dogIndex * percentage); //food collect from supermarket
        dogIndex = dogIndex - (int)(DateInfo.date * 0.03 * dogIndex); //total fridge index minus food cost everyday

        if (dogIndex > 100)
        {
            dogIndex = 100;
        }
        if (dogIndex < 100)
        {

        }
        DogIndex.totalDistance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dogIndex);
        dogImg.fillAmount = dogIndex * 0.01f;
        dogIndexText.text = dogIndex.ToString();
    }
}
