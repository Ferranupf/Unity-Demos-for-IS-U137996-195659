using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Ball;
    public Material NewColor;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.x != 0)
            Ball.GetComponent<MeshRenderer>().material = NewColor;


    }
}
