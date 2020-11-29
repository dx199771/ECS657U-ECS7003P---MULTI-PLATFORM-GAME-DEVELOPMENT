using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    public int index;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    private void Update()
    {
        if (transform.childCount <= 0)   //if this slot has any children
        {
            inventory.isFull[index] = false; //set it to notFull
        }
    }
    //drop the item in the slot
    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject); //destroy each child of slot
        }
    }
}
