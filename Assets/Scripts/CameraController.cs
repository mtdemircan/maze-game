using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;        


    void LateUpdate()
    {
        transform.position = player.transform.position;
        transform.eulerAngles += new Vector3(0,Input.GetAxis("Mouse X"),0);
    }
}
