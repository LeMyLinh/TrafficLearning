﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCommand : Command
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Controller(CarBehaviour car)
    {
        car.StartRun();
    }
}
