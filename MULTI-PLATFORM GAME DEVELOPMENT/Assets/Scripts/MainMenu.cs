using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settings;
    public GameObject info;

    public void PlayGame() { //when click play game, start new game and reset player prefs
        SceneManager.LoadScene("Cutscene");
        PlayerPrefs.DeleteAll();

    }
    public void Countiue() //when click countinee game, load prefs
    {
        SceneManager.LoadScene("Home");
        GameHandler.Load();
    }
    public void QuitGame() { //when quit game close application
        Application.Quit();
        GameHandler.Save();
    }
    //settings and information button event
    public void Settings()
    {
        settings.SetActive(true);
    }
    public void InactiveSettings()
    {
        settings.SetActive(false);
    }
    public void Info()
    {
        info.SetActive(true);
    }
    public void InactiveInfo()
    {
        info.SetActive(false);
    }
}
