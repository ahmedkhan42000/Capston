using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusDrop : MonoBehaviour
{
    public GameObject VirusPf;
    public GameObject DropPoint;

    //GameManager gameManager;
    int StartTime = 3;
    int RepeatRate = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        //gameManager = FindObjectOfType<GameManager>();
        
        InvokeRepeating("DropVirus", StartTime,RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void DropVirus()
    {
       Instantiate(VirusPf, DropPoint.transform.position,Quaternion.identity);
    }
}
