﻿using UnityEngine;
using UnityEngine.SceneManagement;		// Requiered to switch scenes
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        Brick.breakableCount = 0;

		//Debug.Log ("New Level load: " + name);
		//	Application.LoadLevel (name);    -- This method was deprecated a long time ago
		SceneManager.LoadScene(name);
	}

	public void EndGame()
    {
		//Debug.Log ("Quit requested");
		Application.Quit ();
	}

    // Added these functions to our previous LevelManager script.
    public void LoadNextLevel()
    {
        Brick.breakableCount = 0;
        // Load the next scene in the build order
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BrickDestroyed()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
