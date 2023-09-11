using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRay : MonoBehaviour
{
    public Transform cameratransform;
    void Start()
    {

    }
    void Update()
    {
        //currently works for when the screen is at (-10,15,-10) and rotated 45 in the x and z axes
        Vector3 mousepos = Input.mousePosition;
        Vector3 mouseworldpos = Camera.main.ScreenToWorldPoint(mousepos);

        Vector3 casttoplane = new Vector3((10*mouseworldpos.y/15) + mouseworldpos.x, 0, (10*mouseworldpos.y/15) + mouseworldpos.z);
    }
}
