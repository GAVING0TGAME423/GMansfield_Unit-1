using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -12);
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
