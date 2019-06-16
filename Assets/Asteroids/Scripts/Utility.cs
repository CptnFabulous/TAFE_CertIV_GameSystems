using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    
    public static Bounds GetBounds(this Camera cam, float padding = 1f)
    {
        float camHeight, camWidth;
        Vector3 camPos = cam.transform.position;
        camHeight = 2f * cam.orthographicSize;
        camWidth = camHeight * cam.aspect;
        camHeight += padding;
        camWidth += padding;
        return new Bounds(camPos, new Vector3(camWidth, camHeight, 100));
    }

    public static Vector3 GetRandomPosOnBounds(this Bounds bounds)
    {
        Vector3 result = Vector3.zero;
        Vector3 min = bounds.min;
        Vector3 max = bounds.max;
        bool topOrBottom = Random.Range(0, 2) > 0;
        bool top = Random.Range(0, 2) > 0;
        bool right = Random.Range(0, 2) > 0;

        if (topOrBottom)
        {
            result.x = Random.Range(min.x, max.x);
            result.y = top ? max.y : min.y;
        }
        else
        {
            result.x = right ? max.x : min.x;
            result.y = Random.Range(min.y, max.y);
        }
        return result;
    }
    
}