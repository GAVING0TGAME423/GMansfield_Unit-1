using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // all the variables
    private float speed = 15;
    private float turnspeed = 15;
    private float HorizontalInput;
    private float VerticalInput;
    void Start()
    {
        
    }

    
    void Update()
    {
        //inputs are here
       HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        //displays time to the console
        Debug.Log(Time.deltaTime);

        // movement commands come from inputs
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * HorizontalInput * 3);
    }
}
