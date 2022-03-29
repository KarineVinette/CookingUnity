using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class HeatSteack : MonoBehaviour
{
    
   
    private bool heat = false;
    private bool snap = false;
    private bool start = false;
    public GameObject ParticuleHeat;
    public GameObject TextHeat;
    public GameObject TimerSteak;
    int countDownStartValue = 40;
    public Text timerUI;
    public GameObject Steak;
    public GameObject GrilledSteak;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.H) && heat )
        {

            start = true;
            snap = true;
            countDownTimer();
            ParticuleHeat.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            start = false;
            
            ParticuleHeat.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.G)&& countDownStartValue>30)
        {
            timerUI.text = "Wait a little !!!";
        }



    }

    void countDownTimer()
    {
        if (countDownStartValue > 0 && start)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        if (countDownStartValue == 30)
        {
            timerUI.text = "Steak is ready !!!";
            start = true;
            GrilledSteak.SetActive(true);
            Steak.SetActive(false);
        }
        if (countDownStartValue == 0 && start)
        {
            timerUI.text = "GameOver!";
            Destroy(TimerSteak, 4);
            Application.Quit();
        }
    }
   

    private void OnTriggerStay(Collider other)
    {

        if (snap == true)
        {
            Steak.transform.position = new Vector3((float)-3.7, (float)1.3, (float)2.9);

        }
        

       

    }
   
    private void OnTriggerEnter(Collider other)
    {
        TimerSteak.SetActive(true);
        TextHeat.SetActive(true);
        
        if (other.gameObject.name == "Steak")
        {
            heat = true;

        }


    }
    //private void OnTriggerExit(Collider other)
    //{

       
       
    //    start = false;



    //}

}
