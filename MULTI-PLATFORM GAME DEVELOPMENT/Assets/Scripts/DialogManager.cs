using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// This class is dialog manage for displaying, modifying the text of dialog.

public class DialogManager : MonoBehaviour
{
    [SerializeField] private DialogWriter dialogWriter;
    public GameObject scene1;
    public GameObject timer; 
    private Text messageText;
    private AudioSource dialogueAudioSource;
    private int index; //current playing dialog message
    //all the msg from supermarket scene
    public string[] msgList1 = new string[]
    {
        "Ehh, not very good?",
        "Well, hope you can have a good time in the following minutes during your shopping. ",
        "Please notice, you are requested to follow the one way system while you are inside the supermarket. ",
        "Please see arrow signs on the floor.",
        "Use “W-A-S-D” to walk around and “E” to pick up items. ",
        "Also, don’t forget to reference your shopping list showing above.",
        "I don’t think you want to miss getting any items this time.",
        "Oh, another important notice! ",
        "The interior space is not very well ventilated, and possibly there will be rising number of people during the rush hours. ",
        "So please always keep social distancing to others to protect yourselves.",
        "Or your mask will be contaminated and your shopping time will be over.",
        "OK, now are you ready? 3, 2, 1, let’s go!",
        ""
    };
    private void Awake()
    {
        //get dialog text component
        messageText = transform.Find("message").Find("dialogText").GetComponent<Text>();
        dialogueAudioSource = transform.Find("DialogueSound").GetComponent<AudioSource>();
        index = 0;
    }

    public void Msg1()
    {
        Debug.Log(index + "" + msgList1.Length);
        //if all messages displayed, start the game
        if (index >= msgList1.Length-2)
        {
            scene1.SetActive(false);
 
            timer.SetActive(true); //set timer on
            
        }
        //display message when button click
        messageText = transform.Find("message").Find("dialogText").GetComponent<Text>();
        string msg = msgList1[index];
        dialogWriter.AddWriter(messageText, msg, 0.05f, true, true);
        dialogueAudioSource.Play(); //play keyboard sound effect
        index++;


    }

    // Start is called before the first frame update
    private void Start()
    {
        //assign new text to text component
        //messageText.text = "Hi,World!";
        dialogWriter.AddWriter(messageText, "Hey my friend, how are you today? ", 0.05f, true,true);

    }


}
