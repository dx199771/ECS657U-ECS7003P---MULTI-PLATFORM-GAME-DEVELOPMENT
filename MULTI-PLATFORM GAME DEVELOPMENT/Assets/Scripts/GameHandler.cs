using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.CoreModule;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject unitGameObject;
    //private IUnit unit;
    private bool bedTrigger;

    private void Awake()
    {
        //unit = unitGameObject.GetComponent<IUnit>();
    }

    public void Start()
    {
        Save();
    }

    private void Update()
    {
        //bedTrigger = HomeTrigger.bedTrigger;
        //if (Input.GetKeyDown(KeyCode.E) )//&& bedTrigger)
        

        if (Input.GetKeyDown(KeyCode.O))
        {
            Load();
        }
    }

    public static void Save() //Save function
    {
        //Vector3 playerPosition = unit.GetPosition();
        int fridgeIndex = FridgeIndex.fridgeIndex;
        int date = DateInfo.date;
        //PlayerPrefs.SetFloat("PlayerPositionX", playerPosition.x);
        //PlayerPrefs.SetFloat("PlayerPositionY", playerPosition.y);
        //PlayerPrefs.SetFloat("PlayerPositionZ", playerPosition.z);
        PlayerPrefs.SetInt("FridgeIndex", fridgeIndex);
        PlayerPrefs.SetInt("Date", date);
        PlayerPrefs.Save();
    }

    public static void Load()
    {
        if (PlayerPrefs.HasKey("PlayerPositionX"))
        {
            //float playerPositionX = PlayerPrefs.GetFloat("PlayerPositionX");
            //float playerPositionY = PlayerPrefs.GetFloat("PlayerPositionY");
            //float playerPositionZ = PlayerPrefs.GetFloat("PlayerPositionZ");
            //Vector3 playerPosition = new Vector3(playerPositionX, playerPositionY, playerPositionZ);
            
            //unit.SetPosition(playerPosition);
            FridgeIndex.fridgeIndex = PlayerPrefs.GetInt("FridgeIndex");
            DateInfo.date = PlayerPrefs.GetInt("Date");
        }
        else
        {
            
        }
        
    }

}
