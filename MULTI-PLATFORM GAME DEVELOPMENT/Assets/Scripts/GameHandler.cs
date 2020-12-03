using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject unitGameObject;
    private IUnit unit;
    private bool bedTrigger;

    private void Awake()
    {
        unit = unitGameObject.GetComponent<IUnit>();
    }

    private void Update()
    {
        bedTrigger = HomeTrigger.bedTrigger;
        if (Input.GetKeyDown(KeyCode.E) && bedTrigger)
        {
            Save();
        }
    }

    private void Save() //Save function
    {
        Vector3 playerPosition = unit.GetPosition();
        int fridgeIndex = FridgeIndex.fridgeIndex;
        int date = DateInfo.date;
        PlayerPrefs.SetFloat("PlayerPositionX", playerPosition.x);
        PlayerPrefs.SetFloat("PlayerPositionY", playerPosition.y);
        PlayerPrefs.SetFloat("PlayerPositionZ", playerPosition.z);
        PlayerPrefs.SetInt("FridgeIndex", fridgeIndex);
        PlayerPrefs.SetInt("Date", date);
        PlayerPrefs.Save();
    }

}
