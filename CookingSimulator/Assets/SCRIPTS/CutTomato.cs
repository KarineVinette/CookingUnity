using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTomato : MonoBehaviour
{
    public Animator cut;
    private bool toma = false;
    private bool snap = false;
  
    public GameObject TextCut;
    public GameObject PieceOfTomato;
    public GameObject Tomato;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && toma)
        {
            //snap = true;

            StartCoroutine(Transition());

            //if (cut.GetBool("cutTom"))
            //{
            //    cut.SetBool("cutTom", false);
            //}
            //else
            //{
            //    cut.SetBool("cutTom", true);

            //}
            //Tomato.SetActive(false);
            //PieceOfTomato.SetActive(true);
        }
       

    }

    IEnumerator Transition()

    {
        snap = true;
        yield return new WaitForSeconds(1);
       
            cut.SetBool("cutTom", true);

        
        yield return new WaitForSeconds(1);
        Tomato.SetActive(false);
        PieceOfTomato.SetActive(true);
    }


        private void OnTriggerStay(Collider other)
    {
       

        if (snap == true)
        {
            other.transform.position = new Vector3((float)0.2, (float)1.1, (float)1.5);

        }
      


    }
    private void OnTriggerExit(Collider other)
    {
        
        toma = false;

    }
    private void OnTriggerEnter(Collider other)
    {
       
        TextCut.SetActive(true);
        if (other.gameObject.name == "Tomato")
        {
            toma = true;
        }



    }

}
