using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class First : MonoBehaviour
{
    public GameObject Surface;
    public GameObject[] walls;
    public GameObject kamera;
    public GameObject wallprefab;
    public GameObject player;
    public GameObject tavan;
    public GameObject startTrigger;
    public GameObject endTrigger;

    
    
    public Text text;
    
    void Start()
    {
        
        Surface.transform.position = new Vector3(0,0,0);
        tavan.transform.position = new Vector3(0,1f,0);
        //kamera.transform.position = new Vector3(0, 15, 0);
        
        player.transform.position = new Vector3(0.75f,0.25f,-4);
        walls = new GameObject[10];
        startTrigger.transform.position = new Vector3(0.825f, 0.4f, 0.825f - 1.65f);
        startTrigger.transform.Rotate(0,90,0);
        endTrigger.transform.position = new Vector3(0.825f + 4 * 1.65f, 0.4f, 4 * 1.65f + 0.825f);
        endTrigger.transform.Rotate(0,90,0);
        walls[0]=Instantiate(wallprefab, new Vector3(0, 0.4f, 0), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(0, 0.4f, 1.65f), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(0, 0.4f, 2* 1.65f), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(0, 0.4f, 3* 1.65f), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(0, 0.4f, 4* 1.65f), Quaternion.identity);

        //walls[1] = Instantiate(wallprefab, new Vector3(0.825f, 0.4f, 0.825f-1.65f), Quaternion.Euler(0, 90, 0));
        walls[1] = Instantiate(wallprefab, new Vector3(0.825f+1.65f, 0.4f, 0.825f -  1.65f), Quaternion.Euler(0, 90, 0));
        walls[1] = Instantiate(wallprefab, new Vector3(0.825f + 2*1.65f, 0.4f, 0.825f -  1.65f), Quaternion.Euler(0, 90, 0));
        walls[1] = Instantiate(wallprefab, new Vector3(0.825f + 3*1.65f, 0.4f, 0.825f -  1.65f), Quaternion.Euler(0, 90, 0));
        walls[1] = Instantiate(wallprefab, new Vector3(0.825f + 4*1.65f, 0.4f, 0.825f -  1.65f), Quaternion.Euler(0, 90, 0));

        walls[0] = Instantiate(wallprefab, new Vector3(5 * 1.65f, 0.4f, 0), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(5 * 1.65f, 0.4f, 1.65f), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(5 * 1.65f, 0.4f, 2 * 1.65f), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(5 * 1.65f, 0.4f, 3 * 1.65f), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(5 * 1.65f, 0.4f, 4 * 1.65f), Quaternion.identity);

        walls[0] = Instantiate(wallprefab, new Vector3(0.825f, 0.4f, 4 * 1.65f+0.825f), Quaternion.Euler(0, 90, 0));
        walls[0] = Instantiate(wallprefab, new Vector3(0.825f + 1.65f, 0.4f, 4 * 1.65f + 0.825f), Quaternion.Euler(0, 90, 0));
        walls[0] = Instantiate(wallprefab, new Vector3(0.825f + 2*1.65f, 0.4f, 4 * 1.65f + 0.825f), Quaternion.Euler(0, 90, 0));
        walls[0] = Instantiate(wallprefab, new Vector3(0.825f + 3*1.65f, 0.4f, 4 * 1.65f + 0.825f), Quaternion.Euler(0, 90, 0));
        //walls[0] = Instantiate(wallprefab, new Vector3(0.825f + 4*1.65f, 0.4f, 4 * 1.65f + 0.825f), Quaternion.Euler(0, 90, 0));

        walls[3] = Instantiate(wallprefab, new Vector3(1.65f, 0.4f, 0), Quaternion.identity);

        walls[1] = Instantiate(wallprefab, new Vector3(0.825f, 0.4f, 0.825f+1.65f), Quaternion.Euler(0,90,0));
        
        
        walls[4] = Instantiate(wallprefab, new Vector3(0.825f+1.65f, 0.4f, 0.825f + 1.65f), Quaternion.Euler(0, 90, 0));
        walls[4] = Instantiate(wallprefab, new Vector3(0.825f + 1.65f, 0.4f, -0.825f + 1.65f), Quaternion.Euler(0, 90, 0));

        walls[3] = Instantiate(wallprefab, new Vector3(1.65f+2*1.65f, 0.4f, 0), Quaternion.identity);
        walls[3] = Instantiate(wallprefab, new Vector3(1.65f + 2 * 1.65f, 0.4f, 1.65f), Quaternion.identity);
        walls[3] = Instantiate(wallprefab, new Vector3(1.65f + 2 * 1.65f, 0.4f, 2*1.65f), Quaternion.identity);

        walls[1] = Instantiate(wallprefab, new Vector3(0.825f, 0.4f, 0.825f + 1.65f+1.65f), Quaternion.Euler(0, 90, 0));
        walls[1] = Instantiate(wallprefab, new Vector3(0.825f+2*1.65f, 0.4f, 0.825f + 1.65f + 1.65f), Quaternion.Euler(0, 90, 0));

        walls[1] = Instantiate(wallprefab, new Vector3(0.825f+1.65f, 0.4f, 0.825f + 1.65f + 2*1.65f), Quaternion.Euler(0, 90, 0));
        walls[1] = Instantiate(wallprefab, new Vector3(0.825f + 3*1.65f, 0.4f, 0.825f + 1.65f + 2 * 1.65f), Quaternion.Euler(0, 90, 0));

        walls[0] = Instantiate(wallprefab, new Vector3(2*1.65f, 0.4f, 3 * 1.65f), Quaternion.identity);

        walls[0] = Instantiate(wallprefab, new Vector3(3 * 1.65f, 0.4f, 4 * 1.65f), Quaternion.identity);

        walls[0] = Instantiate(wallprefab, new Vector3(4 * 1.65f, 0.4f, 3 * 1.65f), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(4 * 1.65f, 0.4f, 2 * 1.65f), Quaternion.identity);
        walls[0] = Instantiate(wallprefab, new Vector3(4 * 1.65f, 0.4f, 1 * 1.65f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

       
    }


}
