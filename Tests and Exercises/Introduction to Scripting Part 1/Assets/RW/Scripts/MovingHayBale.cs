using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHayBale : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 speed = new Vector3 (0,0,50);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, Space.World);
    }
}
