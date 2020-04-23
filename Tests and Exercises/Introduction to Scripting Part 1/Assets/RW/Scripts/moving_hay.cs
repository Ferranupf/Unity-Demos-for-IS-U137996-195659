﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_hay : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject limitRight;
    public GameObject limitLeft;
    public Vector3 offset = new Vector3(0, -28, 39);
    public GameObject HayBaleParent;
    public GameObject hay_machine;
    void Start()
    {
        limitRight = GameObject.Find("limitRight");
        limitLeft = GameObject.Find("limitLeft");
        hay_machine = GameObject.Find("Hay Machine");

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput < 0 && transform.position.x  > (limitLeft.transform.position.x)) transform.Translate( transform.right * -5 * Time.deltaTime );
        else if (horizontalInput > 0 && transform.position.x  < (limitRight.transform.position.x)) transform.Translate(transform.right * 5 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(HayBaleParent, hay_machine.transform.position + offset, Quaternion.identity);
        }
    }

}
