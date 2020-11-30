using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float finalScore;
    public GameObject gameScreen;
    public Text scoreDisplay;


    public void EndGame(float score) //determine the setting for game over
    {
        Debug.Log("Game Over"); 
        gameScreen.SetActive(true);
        scoreDisplay.text = ("Game End, Your Score is: "+(int)score).ToString(); 

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
