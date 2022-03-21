using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusDrop : MonoBehaviour
{
    public GameObject VirusPf;
    public GameObject DropPoint;

    int StartTime = 2;
    int RepeatRate = 3;
    
    void Start()
    {
        
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
