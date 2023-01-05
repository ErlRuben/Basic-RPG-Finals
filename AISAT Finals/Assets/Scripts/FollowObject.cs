using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    
    public Transform sourceObject;

    void Update()
    {
        //access my own .position and ovveride with player position
        transform.position = sourceObject.position;

    }
    
}
