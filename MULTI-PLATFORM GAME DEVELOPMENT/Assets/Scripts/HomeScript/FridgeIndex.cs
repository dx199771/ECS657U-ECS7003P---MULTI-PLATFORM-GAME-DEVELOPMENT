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
        fridgeIndex = (int)(fridgeIndex + fridgeIndex * percentage); //food collect from supermarket
        fridgeIndex = fridgeIndex - (int)(DateInfo.date* 0.05* fridgeIndex); //total fridge index minus food cost everyday
        
        if (fridgeIndex > 100)
        {
            fridgeIndex = 100;
        }
        if (fridgeIndex < 100)
        {

        }
        ResultsCanvas.percentage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(fridgeIndex);
        fridgeImg.fillAmount = fridgeIndex * 0.01f;
        fridgeIndexText.text = fridgeIndex.ToString();
    }
}
