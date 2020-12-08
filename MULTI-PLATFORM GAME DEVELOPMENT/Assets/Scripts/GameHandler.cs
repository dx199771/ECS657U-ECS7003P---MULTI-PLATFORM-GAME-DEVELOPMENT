using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.CoreModule;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject unitGameObject;
    private bool bedTrigger;

    private void Awake()
    {
    }

    public void Start()
    {
        Save();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Load();
        }
    }

    public static void Save() //Save function
    {
        int fridgeIndex = FridgeIndex.fridgeIndex;
        int date = DateInfo.date;
        PlayerPrefs.SetInt("FridgeIndex", fridgeIndex);
        PlayerPrefs.SetInt("Date", date);
        PlayerPrefs.Save();
    }

    public static void Load()//Load Function
    {
        if (PlayerPrefs.HasKey("FridgeIndex"))
        {
            FridgeIndex.fridgeIndex = PlayerPrefs.GetInt("FridgeIndex");
            DateInfo.date = PlayerPrefs.GetInt("Date");
        }
        else
        {
            
        }
        
    }

}
