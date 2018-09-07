using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public float launchPower = 300.0f;
   
    // Applies an upwards force to any objects with rigidbodies until
    // they are no longer touching the trigger
    void OnTriggerStay (Collider otherObject)
    {
        if (otherObject.attachedRigidbody)
        {
            otherObject.attachedRigidbody.AddForce (Vector3.up * launchPower);
        }
    }
}
