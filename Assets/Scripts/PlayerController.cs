using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15;
    void Start()
    {
        
    }

    
    void Update()
    {
        Debug.Log(Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
