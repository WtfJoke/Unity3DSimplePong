﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int remainingBricks;
    public Text pointsText;
    public int Points
    {
        get { return _points; }
        set
        {
            _points = value;
            pointsText.text = "Points: " + Points;
        }
    }

    private int _points;

    // Use this for initialization
    void Start () {
        remainingBricks = GameObject.FindGameObjectsWithTag("Brick").Length;
        Points = 0;
    }
	
	// Update is called once per frame
	void Update () {
		// TODO restart game on remainingBricks == 0
	}

    public void ReduceBrick()
    {
        remainingBricks -= 1;
        Points++;
    }
}
