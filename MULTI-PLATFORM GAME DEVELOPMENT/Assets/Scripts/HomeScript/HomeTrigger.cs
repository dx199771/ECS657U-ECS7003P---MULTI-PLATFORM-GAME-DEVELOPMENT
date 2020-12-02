using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeTrigger : MonoBehaviour
{
    public GameObject info;
    public Text infoText;
    private bool doorTrigger;
    private bool bedTrigger;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //if door is collision detected
        if (collision.CompareTag("Door"))
        {
            //open door info appear
            info.SetActive(true);
            infoText.text = "Press E to leave the room!";
            doorTrigger = true;
        }
        if (collision.CompareTag("Bed"))
        {
            //open door info appear
            info.SetActive(true);
            infoText.text = "Press E to sleep!";
            bedTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            info.SetActive(false); //hide info panel
            doorTrigger = false;
        }
    }

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.E) && doorTrigger) //if E prssed and doorTrigger active
        {
            SceneManager.LoadScene("Game"); //load next scene
            //anim.Play("transition");

        }
        if (Input.GetKeyDown(KeyCode.E) && bedTrigger) //if E prssed and doorTrigger active
        {
            SceneManager.LoadScene("DateInfo"); //load home scene
        }
    }
}
