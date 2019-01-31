using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScr : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    void QuitGame()
    {
        Application.Quit();
    }

    void GoToCredits()
    {
        SceneManager.LoadScene("");
    }

    void GoToOptions()
    {
        SceneManager.LoadScene("");
    }
}

