using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusDrop : MonoBehaviour
{
    public GameObject VirusPf;
    public GameObject DropPoint;

    int StartTime = 2;
    int RepeatRate = 3;

    VirusDrop virusDropScript;
    void Start()
    {
        virusDropScript = GetComponent<VirusDrop>();
        //InvokeRepeating("DropVirus", StartTime,RepeatRate);
        StartCoroutine("DropVirus");
    }
    void Update()
    {
        
    }
    IEnumerator DropVirus()
    {
        while (virusDropScript.enabled == true)
        {
            Instantiate(VirusPf, DropPoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
