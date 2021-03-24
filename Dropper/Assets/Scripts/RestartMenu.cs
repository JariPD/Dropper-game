using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Niels");
    }


    public void RestartGame()
    {
        SceneManager.LoadScene("Niels");
    }

    public void QuitGame()
    {
        print("you quit");
        Application.Quit();
    }
}
