using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settings;
    public GameObject info;

    public void PlayGame() {
        SceneManager.LoadScene("Cutscene");
        PlayerPrefs.DeleteAll();

    }
    public void Countiue()
    {
        SceneManager.LoadScene("Home");
        GameHandler.Load();
    }
    public void QuitGame() {
        Application.Quit();
        GameHandler.Save();
    }
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
