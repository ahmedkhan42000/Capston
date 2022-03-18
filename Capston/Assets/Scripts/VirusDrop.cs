using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusDrop : MonoBehaviour
{
    public GameObject VirusPf;
    int StartTime = 0;
    int RepeatRate = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DropVirus", StartTime, RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void DropVirus()
    {
       Instantiate(VirusPf, transform.position,Quaternion.identity);
    }
}
