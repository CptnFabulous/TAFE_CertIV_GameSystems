﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    public float padding = 3f;
    public Color debugColour = Color.blue;

    SpriteRenderer sr;

    // Use this for initialization
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    
    // Update is called once per frame
    void LateUpdate()
    {
        UpdatePosition();
    }
    

    private void OnDrawGizmos()
    {
        Bounds camBounds = Camera.main.GetBounds(padding);
        Gizmos.color = debugColour;
        Gizmos.DrawWireCube(camBounds.center, camBounds.size);
    }

    void UpdatePosition()
    {
        Bounds camBounds = Camera.main.GetBounds(padding);
        Vector3 pos = transform.position;
        Vector3 min = camBounds.min;
        Vector3 max = camBounds.max;

        if (pos.x < min.x)
        {
            pos.x = max.x;
        }
        if (pos.x > max.x)
        {
            pos.x = min.x;
        }
        if (pos.y < min.y)
        {
            pos.y = max.y;
        }
        if (pos.y > max.y)
        {
            pos.y = min.y;
        }

        transform.position = pos;
    }
}
