using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DateInfo : MonoBehaviour
{
    public static int date = 1;
    public Text dateDisplay;

    // Start is called before the first frame update
    void Start()
    {
        dateDisplay.text = "Day "+ date.ToString(); //display the date on canvas
        date += 1; // add one more day after load the scenes
        StartCoroutine(waiter());

    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(3); //delay for 3 second
        SceneManager.LoadScene("Home"); //load home scene

    }
}
