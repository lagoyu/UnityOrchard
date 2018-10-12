using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

    public float baseSpeed = 4.0f;

    public float runMultiplier = 2.0f;

    // Use this for initialization
    void Start () 
    {
		// Move cursor to middle of play window and hide it
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update ()
    {
        // Move player in response to keys pressed
		KeyMovement();

        // Unlock cursor when escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    private void KeyMovement()
    {

		float speed = GetSpeed();

		// Default axis keys are WASD or cursor keys
		float forwardAndBack = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;

		// Time.deltaTime enables smooth movemnt irrespective of system speed
        forwardAndBack = forwardAndBack * Time.deltaTime;
        straffe = straffe * Time.deltaTime;

		// FIX THE LOGIC ERROR IN THE NEXT LINE
		transform.Translate(forwardAndBack, 0, straffe);
    }

	float GetSpeed()
	{
		if (Input.GetKey (KeyCode.LeftShift)) 
		{
			// FIX THE NEXT LINE TO ENABLE THE PLAYER TO RUN
			return baseSpeed;
		}
		else 
		{
			return baseSpeed;
		}
	}

    private  void QuitGame()
    {
		// Show the mouse cursor again
		Cursor.lockState = CursorLockMode.None;
		// Note: Quit only works outside of Unity editor when
		// running built project (File>Build & Run)
		Application.Quit ();

    }
}
