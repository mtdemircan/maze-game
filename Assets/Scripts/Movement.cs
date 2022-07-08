using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        
        float zDir = Input.GetAxis("Vertical");
        
        GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward*zDir);

        
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y<0.3f)
        {
           
            Vector3 jump = new Vector3(0,150,0);
            GetComponent<Rigidbody>().AddForce(jump);
        }
    }
}
