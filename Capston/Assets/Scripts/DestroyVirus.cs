using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVirus : MonoBehaviour
{
    //GameManager gameManager;
   public int DestoryVirusTime;
    // Start is called before the first frame update
    void Start()
    {
        //gameManager = FindObjectOfType<GameManager>();
        Destroy(gameObject, DestoryVirusTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
