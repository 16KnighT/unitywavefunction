using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float movespeed = 2f;

    public Rigidbody rb;

    private Vector3 movement;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(x, 0, z);
        transform.Translate(movement*movespeed*Time.deltaTime);
    }

    void FixedUpdate()
    {
        
    }
}
