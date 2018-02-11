using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    //This method is triggered when the ball touches the LoseCollider game object.
    // It loads the "Lose" scene
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelManager levelManager = new LevelManager();
        Debug.Log("hola");
        levelManager.LoadLevel("Lose");
    }
}
