using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour 
{

    // FIX THE DATA TYPE MISMATCH 
    int rotationDegrees = 16.5f;

    // Update is called once per frame.  
    void Update()
    {
        //Time.deltaTime is the time in seconds since last call.
        //FIX THE SYNTAX ERROR ON THE NEXT LINE; SOMETHING IS MISSING
        transform.Rotate(Vector3.up, rotationDegrees * Time.deltaTime, Space.World)
    }
}
