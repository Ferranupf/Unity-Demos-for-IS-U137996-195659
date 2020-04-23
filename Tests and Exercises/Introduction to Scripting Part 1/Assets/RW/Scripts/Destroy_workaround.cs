using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_workaround : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Hay;
    void Start()
    {
        
       

    }

    // Update is called once per frame
    void Update()
    {
        if ( Hay.transform.position.z > 130 )
        {
            Destroy(Hay);
        }
    }
}
