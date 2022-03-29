

using System;  
using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AddTimer : MonoBehaviour
{
    int countDownStartValue = 300;
    public Text timerUI;
    public GameObject Timer;
     

    void Start() 
    {
        countDownTimer();

    }

    void countDownTimer()

    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();
        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "CookingMe")
        {
            Timer.SetActive(true);

              if (countDownStartValue > 0 )
            {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
            }
            else
            {
            timerUI.text = "GameOver!";
            Destroy(Timer, 4);
            Application.Quit();

            }
        }
    }
    void Update() { }

   
}