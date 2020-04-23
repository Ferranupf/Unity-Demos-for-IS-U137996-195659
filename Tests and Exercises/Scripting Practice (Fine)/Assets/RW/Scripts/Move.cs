using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 movementSpeed; //1
    public Space space; //2

    void Start()
    {
       // movementSpeed = new Vector3(0,0,20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementSpeed * Time.deltaTime, space);
    }
}
