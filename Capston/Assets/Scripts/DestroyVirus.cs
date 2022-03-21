using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVirus : MonoBehaviour
{
   public int DestoryVirusTime = 10;

    void Start()
    {
        Destroy(gameObject, DestoryVirusTime);
    }

    void Update()
    {
        
    }
}
