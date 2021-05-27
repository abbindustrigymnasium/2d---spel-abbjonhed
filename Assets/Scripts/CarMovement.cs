using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{   
    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed;
    public float carTorque;
    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal"); // get an integer(-1, 0 or 1) from the arrow keys depending on if the left or right arrow keys are pressed
    }
    private void FixedUpdate()
    {
        backTire.AddTorque(-movement * speed * Time.fixedDeltaTime); // make the wheels spin with addtorque. addtorque is used to not have a super fast acceleration.
        frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        carRigidbody.AddTorque(movement * carTorque * Time.fixedDeltaTime); // make the whole car spin with addtorque. to make the car controllable in the air. 
    }
}
