using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVirus : MonoBehaviour
{
    public GameObject VirusDestroy_ParticleEffect;
    int DestoryVirusTime = 10;

    void Start()
    {
        
        Destroy(gameObject, DestoryVirusTime);
        StartCoroutine(Virus_Effect());
    }

    void Update()
    {
        
    }
    IEnumerator Virus_Effect()
    {
        yield return new WaitForSeconds(DestoryVirusTime - 0.2f);
        Instantiate(VirusDestroy_ParticleEffect, transform.position, transform.rotation);
    }
}
