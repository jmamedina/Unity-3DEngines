using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class for the main camera and added it to the player which is the vehicle
public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // player = vehicle

    //this is the offset of the main camera to the vehicle
    //the numbers is the main camera's position
    private Vector3 offset = new Vector3(0, 5, -7); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // LateUpdate method is updating the class after the player's update
    // When we use update only the update of the vehicle is updating together with the camera's update
    // so we late update the method so that they will move consecutive
    void LateUpdate()
    {

        //offset the camera behind the player by adding the players position
        //offset is the vector 3 variable
        transform.position = player.transform.position + offset;
    }
}
