﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {


    // Use this for initialization
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
