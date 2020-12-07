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
    public static bool bedTrigger;
    private bool dogTrigger;
    public GameObject dog;
    public Animator transition;
    public float transitionTime = 5f;
    static public bool dogLeaded;
    private Transform heroTransform;
    public float followSpeed;
    
    //public position;

    void Start()
    {
        heroTransform = GameObject.FindGameObjectWithTag("Player").transform; //get player position
        dogLeaded = false; //reset dog leaded
        bedTrigger = false; //reset bed trigger
    }

    private void OnTriggerStay2D(Collider2D collision) // when stay in trigger area
    {
        //if door is collision detected
        if (collision.CompareTag("Door"))
        {
            //open door info appear
            info.SetActive(true);
            infoText.text = "Press E to leave the room!"; //change info text
            doorTrigger = true; // set trigger on
        }
        if (collision.CompareTag("Bed"))
        {
            //sleep info appear
            info.SetActive(true);
            infoText.text = "Press E to sleep!";
            bedTrigger = true;
        }
        if (collision.CompareTag("Dog"))
        {
            //open door info appear
            info.SetActive(true);
            infoText.text = "Press E to lead the dog!";
            dogTrigger = true; //set lead dog trigger on
        }
    }
    private void OnTriggerExit2D(Collider2D collision) // when leave trigger area
    {
        if (collision.CompareTag("Door"))
        {
            info.SetActive(false); //hide info panel
            doorTrigger = false;
        }
        if (collision.CompareTag("Bed"))
        {
            info.SetActive(false); //hide info panel
            bedTrigger = false;
        }
        if (collision.CompareTag("Dog"))
        {
            info.SetActive(false); //hide info panel
            dogTrigger = false;
        }

    }
    IEnumerator animation(string scene)
    {
        transition.SetTrigger("start");//set animation on
        yield return new WaitForSeconds(transitionTime); //wait for seconds
        SceneManager.LoadScene(scene);//change scene
    }
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.E)) //if E prssed and trigger active
        {
            if (doorTrigger)
            {
                StartCoroutine(animation("Street"));
                //SceneManager.LoadScene("Street"); //load street scene
            }
            if (bedTrigger)
            {
                StartCoroutine(animation("DateInfo"));
            }
            if (dogLeaded == false && dogTrigger)
            {
                dogLeaded = true; //if dog has been leaded
            }


        }
        if (dogTrigger && dogLeaded)
        {
            dog.transform.position = Vector3.Lerp(dog.transform.position, heroTransform.position, Time.deltaTime * followSpeed); //smooth translate dog position to hero position
        }

    }

}
