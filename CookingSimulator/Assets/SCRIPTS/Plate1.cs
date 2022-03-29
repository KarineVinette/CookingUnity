using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate1 : MonoBehaviour
{
    
    private bool trig = false;
    public GameObject Burger1;
    public GameObject Cheese;
    public GameObject GrilledSteak;
    public GameObject Salad;
    public GameObject PieceOfTomato;
    public GameObject BottomBread;
    public GameObject TopBread;
    public GameObject TextEnd;
    public GameObject TextHeat;
    public GameObject TextCut;
    public GameObject TextSpace;
    public GameObject TextGrab;
    public GameObject Timer;
    private bool Chees = false;
    private bool Grill = false;
    private bool Sala = false;
    private bool Piec = false;
    private bool Botto = false;
    private bool Top = false;
    public GameObject ParticuleSystemEnd;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) )
        {

            trig = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        
           
        if ( other.gameObject.name == "Cheese" && trig)
        {
            Burger1.transform.Find("Cheese").gameObject.SetActive(true);
            Destroy(Cheese);
            Chees = true;

        }
        if ( other.gameObject.name == "GrilledSteak" && trig)
        {
            Burger1.transform.Find("GrilledSteak").gameObject.SetActive(true);
            Destroy(GrilledSteak);
            Grill = true;


        }
        if (other.gameObject.name == "Salad" && trig)
        {
            Burger1.transform.Find("Salad").gameObject.SetActive(true);
            Destroy(Salad);
            Sala = true;

        }
        if ( other.gameObject.name == "BottomBread" && trig)
        {
            Burger1.transform.Find("BottomBread").gameObject.SetActive(true);
            Destroy(BottomBread);
            Botto = true;

        }
        if ( other.gameObject.name == "TopBread" && trig)
        {
            Burger1.transform.Find("TopBread").gameObject.SetActive(true);
            Destroy(TopBread );
            Top = true;

        }
        if ( other.gameObject.name == "PieceOfTomato" && trig)
        {
            Burger1.transform.Find("PieceOfTomato").gameObject.SetActive(true);
            Destroy(PieceOfTomato);
            Piec = true;

        }
        if (Piec==true && Top==true && Botto == true && Sala== true && Grill == true && Chees == true  )
        {
            ParticuleSystemEnd.SetActive(true);
            Burger1.transform.localScale  = new Vector3(6,6,6);
            TextEnd.SetActive(true);
            Destroy(TextHeat);
            Destroy(TextCut);
            Destroy(TextSpace);
            Destroy(TextGrab);
            Destroy(Timer);
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        trig = false;
    }
   
}
