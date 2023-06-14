using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the player or vehicle's main controller
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; //speed of vehicle

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the player forward
        //Time = get the time
        //deltatime = interval per seconds
        //speed is the variable speed

        transform.Translate(Vector3.forward * Time.deltaTime * speed); 
    }
}
