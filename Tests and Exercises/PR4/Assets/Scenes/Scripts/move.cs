using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    Boolean set = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(2*Input.GetAxis("Horizontal")*Time.deltaTime,3*Input.GetAxis("Vertical")*Time.deltaTime,0f);
        if (Input.GetKeyDown(KeyCode.Space)) set = true;
        if (set)
        {
            transform.Translate(0f, 0f, 30 * Time.deltaTime);
           // transform.Rotate(new Vector3(10,0,0),Space.World);
        }

    }
}
