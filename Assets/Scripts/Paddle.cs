using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    // Attributes
    public bool autoPlay = false;
    public float minX;
    public float maxX;

    private Ball ball;

	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay)
        {
            MoveWithMouse();
        } else
        {
            AutoPlay();
        }
	}

    //arrrowRightb
    void MoveWithMouse()
    {
        // Here we need to obtain the mouse position and transform it to a
        // valid screen position in x
        Vector3 paddlePos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        float mousePosInBlocks = (Input.mousePosition.x / Screen.width) * 16 - 8;

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, minX, maxX);
        //Debug.Log(Input.mousePosition.x + "," + Screen.width);
        this.transform.position = paddlePos;
    }

    void AutoPlay()
    {
        Vector3 paddlePos = this.transform.position;
        Vector3 ballPos = ball.transform.position;

        paddlePos.x = Mathf.Clamp(ballPos.x, minX, maxX);

        this.transform.position = paddlePos;
    }

}
