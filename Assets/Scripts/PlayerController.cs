using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the player or vehicle's main controller
public class PlayerController : MonoBehaviour
{
    //use public if you want to change the value of the variable on the unity editor
    //private if you want to use the declared value of the variable
    private float speed = 10.0f; //speed of vehicle
    private float turnSpeed = 25.0f; //speed of turn
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //get the Input -> horizontal || vertical
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move the player forward
        //Time = get the time
        //deltatime = interval per seconds
        //speed is the variable speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //this is for moving left and right only
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        //rotate the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
