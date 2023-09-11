using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGrid : MonoBehaviour 
{
    public GameObject[] tiles;
    public int tilesize = 1;
    public int width;
    public int height;

    private int[,] grid2D;

    void Start() 
    {
        for (int x = 0; x < width; x++) 
        {
            for (int z = 0; z < height; z++) 
            {
                Vector3 spawnpos = new Vector3(x * tilesize, 0, z * tilesize);
                spawn(spawnpos);
            }
        }
    }

    void spawn(Vector3 spawnpos)
    {
         Instantiate(tiles[Random.Range(0, tiles.Length)], spawnpos, Quaternion.identity);
    }
}
