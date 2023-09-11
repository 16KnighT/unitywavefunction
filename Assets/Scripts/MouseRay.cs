using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRay : MonoBehaviour
{
    public GameObject gridgen;
    public Transform cameratransform;
    int tilesize;
    int width;
    int height;
    void Start()
    {
        MyGrid mygrid = gridgen.GetComponent<MyGrid>();
        tilesize = mygrid.tilesize;
        width = mygrid.width;
        height = mygrid.height;
    }
    void Update()
    {
        //currently works for when the screen is rotated 45 in the x and z axes

        //-----CAST MOUSE POSITION ONTO THE PLANE-----
        Vector3 mousepos = Input.mousePosition;
        Vector3 mouseworldpos = Camera.main.ScreenToWorldPoint(mousepos);

        Vector3 casttoplane = new Vector3((10*mouseworldpos.y/15) + mouseworldpos.x, 0, (10*mouseworldpos.y/15) + mouseworldpos.z);

        //-----HIGHLIGHT SELECTED TILE-----
        float tileorigin = tilesize/2;
        float mousetilex = Mathf.Floor((casttoplane.x+tileorigin)/tilesize);
        float mousetilez = Mathf.Floor((casttoplane.z+tileorigin)/tilesize);

        Vector3 point1 = new Vector3(mousetilex*tilesize - tileorigin, 0, mousetilez*tilesize - tileorigin);
        Vector3 point2 = new Vector3(mousetilex*tilesize + tilesize - tileorigin, 0, mousetilez*tilesize - tileorigin);
        Vector3 point3 = new Vector3(mousetilex*tilesize + tilesize - tileorigin, 0, mousetilez*tilesize + tilesize - tileorigin);
        Vector3 point4 = new Vector3(mousetilex*tilesize - tileorigin, 0, mousetilez*tilesize + tilesize - tileorigin);

        Debug.DrawLine(point1, point2);
        Debug.DrawLine(point2, point3);
        Debug.DrawLine(point3, point4);
        Debug.DrawLine(point4, point1);


    }
}
