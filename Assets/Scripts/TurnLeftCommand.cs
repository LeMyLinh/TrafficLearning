﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLeftCommand : MonoBehaviour, IController<CarBehaviour> {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Controller(CarBehaviour car)
    {
        car.TurnLeft();
    }
}
