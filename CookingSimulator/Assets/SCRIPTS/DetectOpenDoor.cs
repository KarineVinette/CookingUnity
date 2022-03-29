using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOpenDoor : MonoBehaviour
{
    public Animator OpenDoor;
    public GameObject TextSpace;
    public GameObject TextGrab;
    private bool inTrigger = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& inTrigger)
        {
            if (OpenDoor.GetBool("Open"))
            {
               
                OpenDoor.SetBool("Open", false);

            }
            else
                OpenDoor.SetBool("Open", true);
                TextSpace.SetActive(false);
                TextGrab.SetActive(true);
        }
        
            
        
    }
    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
        TextSpace.SetActive(true);
        if (OpenDoor.GetBool("Open"))
        {
            TextSpace.SetActive(false);
            TextGrab.SetActive(true);
        }
        }
    private void OnTriggerExit(Collider other)
    {
        TextSpace.SetActive(false);
        TextGrab.SetActive(true);
        inTrigger = false;

    }
}