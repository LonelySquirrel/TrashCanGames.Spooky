﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform target;

    private void FixedUpdate()
    {
        transform.position = target.position;
        // simpel kod för att kameran ska följa spelaren
    }
}// Hjalmar Heike
