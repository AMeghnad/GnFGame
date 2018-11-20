using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Play()
    {
        SceneManager.LoadScene(1);
    }

    void Options()
    {

    }

    void Exit()
    {
        Application.Quit();
    }
}
