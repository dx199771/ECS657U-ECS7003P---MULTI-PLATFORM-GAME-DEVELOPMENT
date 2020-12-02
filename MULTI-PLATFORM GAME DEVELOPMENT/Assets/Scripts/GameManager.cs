using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float finalScore;
    public GameObject gameScreen;


    public void EndGame(float score) //determine the setting for game over
    {
        Debug.Log("Game Over"); 
        gameScreen.SetActive(true);

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //exit supermarket and return to home scene
    public void ExitSupermarket()
    {
        SceneManager.LoadScene("DateInfo"); // load date info
    }

}
