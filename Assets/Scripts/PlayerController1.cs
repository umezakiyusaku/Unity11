﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * 5.0f * Time.deltaTime);
    }

}

