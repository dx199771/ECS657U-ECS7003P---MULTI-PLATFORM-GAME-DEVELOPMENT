using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ResultsCanvas : MonoBehaviour
{
    public Text resultText;
    public Image[] childImages;
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public GameObject[] slots;
    private string[] collectedItems = {"0", "0", "0", "0", "0", "0" };
    private int collectedItem;
    public static float percentage;
    void Start()
    {
        percentage = 0;
        //display shoppping list objects in result panel
        childImages[0].sprite = image1.sprite;
        childImages[1].sprite = image2.sprite;
        childImages[2].sprite = image3.sprite;
        childImages[3].sprite = image4.sprite;
        childImages[4].sprite = image5.sprite;
        childImages[5].sprite = image6.sprite;
        compareObjects();
        collectedItem = Count(collectedItems);
        percentage = (float)Math.Round((double)(collectedItem / 6.0), 2); //round up
        resultText.text = "You have collected "+ collectedItem + " items. Your fridge has been filled "+ percentage * 100.0f + "% percent";

    }
    int Count(string[] collectedItems)
    {
        int counter = 0;
        for (int i = 0; i < collectedItems.Length; i++)
        {
            if (collectedItems[i]=="1")
            {
                counter++;
            }
        }
        return counter;
    }

    void compareObjects()         //compare shopping list and shopping cart objects 
    {
        //convert array to list that enable object remove
        List<GameObject> gameObjects = new List<GameObject>(slots);
        //compare each shopping list item
        for (int j = 0; j < childImages.Length; j++)
        {
            Image currentImg = childImages[j].GetComponent<Image>(); // get current shopping list item
            for (int i = 0; i < gameObjects.Count; i++) //compare each shopping cart item
            {
                if (gameObjects[i].transform.childCount > 0) //shopping cart not empty
                {
                    //if item name match in cart and list
                    if (gameObjects[i].transform.GetChild(0).GetComponent<Image>().sprite.ToString() == currentImg.sprite.ToString())
                    {
                        //collected item flag to one
                        collectedItems[j] = "1";
                        Debug.Log(collectedItems);
                        gameObjects.RemoveAt(i);
                        Debug.Log(i + "------" + j);
                        childImages[j].transform.Find("Correct").gameObject.SetActive(true); //active correct sign
                        childImages[j].transform.Find("Incorrect").gameObject.SetActive(false);//deactive incorrect sign
                    }
                }
                
            }
        }


    }

}
