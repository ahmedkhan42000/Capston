using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToEnemy : MonoBehaviour
{
    public GameObject Indicator;
    VirusDrop VDScript;
    // Start is called before the first frame update
    void Start()
    {
        //VDScript = GameObject.Find("Character_Civilian1").GetComponent<VirusDrop>();
        VDScript = GetComponent<VirusDrop>();
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Virus")
        {
            Debug.Log(gameObject.name + " Collided with " + collision.gameObject.name + "Virus Destroyed --->In ConvertToEnemy Script");
            VDScript.enabled = true;
            Destroy(collision.gameObject);
            Indicator.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
        }
    }
}
