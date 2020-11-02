﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform heroTransform;
    void Start()
    {
        heroTransform = GameObject.FindGameObjectWithTag("Player").transform; //initiate camera position on the player
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = heroTransform.position; //relocate camera to the position of the player so the camera follows the player
        temp.x = heroTransform.position.x;
        temp.y = heroTransform.position.y;
        temp.z = -1;
        transform.position = temp;
    }
}
