using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform target;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - target.position; // save offset from car to screen to have the car in the same place of the screen.
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.position + offset; // allways move camera to the position of the car + the offset
	}
}
