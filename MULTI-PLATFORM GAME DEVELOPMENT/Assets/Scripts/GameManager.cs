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
        SceneManager.LoadScene("Menu"); //exit to main menu

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //exit supermarket and return to home scene
    public void ExitSupermarket()
    {
        SceneManager.LoadScene("DateInfo"); // load date info
        SoundManager.PlaySound(SoundManager.Sound.PayBill); //use the checkout sound effect
    }

}
