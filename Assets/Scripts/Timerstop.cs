using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timerstop : MonoBehaviour
{
    public Text t;
    public Text t2;
    public GameObject t22;
    
    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        t.enabled = false;
        t22.SetActive(true);
        t2.text = t.text + " saniyede bitirdiniz.";
        
        
    }
    
}
