using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StreetTrigger : MonoBehaviour
{
    public GameObject info;
    public Text infoText;
    private bool parkTrigger;
    private bool supermarketTrigger;
    public Animator transition;
    public float transitionTime;
    static public bool dogLeaded;
    public GameObject dog;

    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && parkTrigger) //if E prssed and parkTrigger active
        {
            StartCoroutine(animation("Park")); //load Park scene
            //anim.Play("transition");

        }
        if (Input.GetKeyDown(KeyCode.E) && supermarketTrigger) //if E prssed and marketTrigger active
        {
            StartCoroutine(animation("Game")); //load supermarket scene
        }
        //if dog is leaded
        dogLeaded = HomeTrigger.dogLeaded;
        if (dogLeaded)
        {
            dog.SetActive(true);
        }

    }

    IEnumerator animation(string scene)
    {
        transition.SetTrigger("start");//set animation on
        yield return new WaitForSeconds(transitionTime); //wait for seconds
        SceneManager.LoadScene(scene);//change scene
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //if door is collision detected
        if (collision.CompareTag("Park"))
        {
            //open door info appear
            info.SetActive(true);
            infoText.text = "Press E to go to park!";
            parkTrigger = true;
        }
        if (collision.CompareTag("Market"))
        {
            //open door info appear
            info.SetActive(true);
            infoText.text = "Press E to go to supermarket!";
            supermarketTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Market"))
        {
            info.SetActive(false); //hide info panel
            supermarketTrigger = false;
        }
        if (collision.CompareTag("Park"))
        {
            info.SetActive(false); //hide info panel
            parkTrigger = false;
        }
    }
}
