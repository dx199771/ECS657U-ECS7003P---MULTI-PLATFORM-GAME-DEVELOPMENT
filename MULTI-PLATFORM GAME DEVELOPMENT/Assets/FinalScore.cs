using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalScore : MonoBehaviour
{
    public float finalScore;
    public GameObject player;
    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        float finalScore = GameObject.FindWithTag("Player").GetComponent<PlayerControl>().score; 


        scoreDisplay.text = ((int)finalScore).ToString(); //Display final score
    }


}
