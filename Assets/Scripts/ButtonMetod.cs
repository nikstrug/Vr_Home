using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMetod : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene("Main");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitFunction()
    {
        Application.Quit();
    }
}
