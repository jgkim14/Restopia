﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainview : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        //transform.rotation = player.transform.rotation;
    }
}
