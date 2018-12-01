using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace LavaleyGame
{
    public class MainMenu : MonoBehaviour
    {
        public bool showOptions;

        // Use this for initialization
        void Start()
        {
            showOptions = false;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Play()
        {
            SceneManager.LoadScene(1);
        }

        public void Options()
        {
            showOptions = !showOptions;
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}
