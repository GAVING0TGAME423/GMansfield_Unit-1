using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Debug.Log(Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
    }
}
