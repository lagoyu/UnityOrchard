using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    // FIX THE DATA TYPE SO THAT IT HANDLES FLOATING POINT NUMBERS
    int rotationDegrees = 16.5f;

    // Update is called once per frame.  
    void Update()
    {
        //Time.deltaTime is the time in seconds since last call of Update.
        //FIX THE SYNTAX ERROR AT THE END OF THE NEXT LINE; 
        transform.Rotate(Vector3.up, rotationDegrees * Time.deltaTime, Space.World)
    }
}



// =============== SOLUTIONS FURTHER DOWN IF YOU ARE COMPETELY STUCK =======================


































// Solutions:
// Line 9 (CHANGE int TO float)
// Line 16 (A SEMICOLON IS MISSING AT THE END OF THE LINE)
