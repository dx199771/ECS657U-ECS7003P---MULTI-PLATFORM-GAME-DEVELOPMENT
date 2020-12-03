using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FridgeIndex : MonoBehaviour
{
    public Image fridgeImg; //load fridge image
    public Text fridgeIndexText;
    public static int fridgeIndex = 50; //inital fridge index
    float percentage;

    // Start is called before the first frame update
    void Start()
    {
        percentage = ResultsCanvas.percentage;
        fridgeIndex = (int)(fridgeIndex + fridgeIndex * percentage);
        if (fridgeIndex > 100)
        {
            fridgeIndex = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        fridgeImg.fillAmount = fridgeIndex * 0.01f;
        fridgeIndexText.text = fridgeIndex.ToString();
    }
}
