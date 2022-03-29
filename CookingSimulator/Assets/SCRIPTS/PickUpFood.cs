using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFood : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform TheDest;
    public Animator OpenDoor;
    private bool taken = false;
    public GameObject Cheese;
    public GameObject Salad;
    public GameObject BottomBread;
    public GameObject TopBread;
    public GameObject Steak;
    public GameObject Tomato;
    public GameObject PieceOfTomato;
    public GameObject GrilledSteak;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && OpenDoor.GetBool("Open"))
        {

            Cheese.transform.position = TheDest.position;
            Cheese.transform.parent = GameObject.Find("Dest").transform;
            taken = true;

        }
        if (Input.GetKeyDown(KeyCode.R) && taken)
        {

            Cheese.transform.position = TheDest.position;
            Cheese.transform.parent = GameObject.Find("Dest").transform;
            taken = false;


        }


        if (Input.GetKeyDown(KeyCode.Z) && OpenDoor.GetBool("Open"))
        {

            Salad.transform.position = TheDest.position;
            Salad.transform.parent = GameObject.Find("Dest").transform;
            taken = true;

        }
        if (Input.GetKeyDown(KeyCode.Z) && taken)
        {

            Salad.transform.position = TheDest.position;
            Salad.transform.parent = GameObject.Find("Dest").transform;
            taken = false;


        }
        if (Input.GetKeyDown(KeyCode.T) && OpenDoor.GetBool("Open"))
        {

            BottomBread.transform.position = TheDest.position;
            BottomBread.transform.parent = GameObject.Find("Dest").transform;
            taken = true;

        }
        if (Input.GetKeyDown(KeyCode.T) && taken)
        {

            BottomBread.transform.position = TheDest.position;
            BottomBread.transform.parent = GameObject.Find("Dest").transform;
            taken = false;


        }
        if (Input.GetKeyDown(KeyCode.Y) && OpenDoor.GetBool("Open"))
        {

            TopBread.transform.position = TheDest.position;
            TopBread.transform.parent = GameObject.Find("Dest").transform;
            taken = true;
        }
        if (Input.GetKeyDown(KeyCode.Y) && taken)
        {

            TopBread.transform.position = TheDest.position;
            TopBread.transform.parent = GameObject.Find("Dest").transform;
            taken = false;


        }
        if (Input.GetKeyDown(KeyCode.A) && OpenDoor.GetBool("Open"))
        {

            Steak.transform.position = TheDest.position;
            Steak.transform.parent = GameObject.Find("Dest").transform;
            taken = true;

        }
        if (Input.GetKeyDown(KeyCode.A) && taken)
        {

            Steak.transform.position = TheDest.position;
            Steak.transform.parent = GameObject.Find("Dest").transform;
            taken = false;

        }
        if (Input.GetKeyDown(KeyCode.E) && OpenDoor.GetBool("Open"))
        {

            Tomato.transform.position = TheDest.position;
            Tomato.transform.parent = GameObject.Find("Dest").transform;
            taken = true;

        }
        if (Input.GetKeyDown(KeyCode.E) && taken)
        {

            Tomato.transform.position = TheDest.position;
            Tomato.transform.parent = GameObject.Find("Dest").transform;
            taken = false;

        }
        if (Input.GetKeyDown(KeyCode.U))
        {

            PieceOfTomato.transform.position = TheDest.position;
            PieceOfTomato.transform.parent = GameObject.Find("Dest").transform;



        }
        if (Input.GetKeyDown(KeyCode.G))
        {

            GrilledSteak.transform.position = TheDest.position;
            GrilledSteak.transform.parent = GameObject.Find("Dest").transform;


        }


        if (Input.GetKeyDown(KeyCode.X))
        {
            Cheese.transform.parent = null;
            Salad.transform.parent = null;
            BottomBread.transform.parent = null;
            TopBread.transform.parent = null;
            Steak.transform.parent = null;
            Tomato.transform.parent = null;
            PieceOfTomato.transform.parent = null;
            GrilledSteak.transform.parent = null;
        }

    }
}
