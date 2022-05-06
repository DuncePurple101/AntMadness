using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Katarina");
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void PauseMenuScene()
    {
        SceneManager.LoadScene("PauseMenu");
    }
    public void LoseScreen()
    {
        SceneManager.LoadScene("Lose");
    }
    public void WinScreen()
    {
        SceneManager.LoadScene("Win");
    }
}
