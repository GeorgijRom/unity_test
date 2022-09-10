using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelZero");
    }
    public void QuitGame()
    {

        Application.Quit();
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }

}
