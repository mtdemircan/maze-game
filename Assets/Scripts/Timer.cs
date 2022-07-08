using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Timer : MonoBehaviour
{
    

    private float timer=0;
    public Text text;
    bool yes = false;
    
    void Update()
    {
        if (yes)
        {
;           timer += Time.deltaTime;
            text.text = Mathf.Round(timer).ToString();
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        yes = true;
        
    }
}
