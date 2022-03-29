using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speedRatio = 2.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = Time.deltaTime * speedRatio;

        transform.position += Input.GetAxis("Vertical") * Vector3.forward * speed;
        transform.position += Input.GetAxis("Horizontal") * Vector3.back * speed;
        transform.position += Input.GetAxis("Left") * Vector3.left * speed;
        transform.position += Input.GetAxis("Right") * Vector3.right * speed;

        //    if (Input.GetKey(KeyCode.UpArrow))
        //        transform.position += Vector3.forward * speed;
        //    if (Input.GetKey(KeyCode.DownArrow))
        //        transform.position += Vector3.back * speed;

        //if (Input.GetKey(KeyCode.LeftArrow))
        //        transform.position += Vector3.left* speed;

        //if (Input.GetKey(KeyCode.RightArrow))
        //         transform.position += Vector3.right * speed;
    }

}