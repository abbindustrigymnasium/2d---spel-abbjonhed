using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fail : MonoBehaviour
{   
    public Transform car; //reference the object that you want to move
    public Transform newCarLocation; //reference the location of where you want it

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other) // run when the characters head collides with another object(the ground)
    {
        car.position = newCarLocation.position; // teleport the car and character to the start 
    }
}
