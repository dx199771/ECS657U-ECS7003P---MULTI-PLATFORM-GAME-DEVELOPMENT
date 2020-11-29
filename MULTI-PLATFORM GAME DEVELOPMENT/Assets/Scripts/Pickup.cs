using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    public Text pickupInfoText;
    public GameObject pickupInfo;
    private bool collide;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && collide == true)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                Debug.Log(inventory.isFull[i]);
                if (inventory.isFull[i] == false)
                {
                    //item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false); //define which cart slot the picked item goes to
                    //Destroy(gameObject);
                    break;
                }
            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            collide = true;
            pickupInfo.SetActive(true);
            pickupInfoText.text = "Press E to pick up "+ itemButton.name+ "!";

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pickupInfo.SetActive(false);
            collide = false;      
        }
    }
}
