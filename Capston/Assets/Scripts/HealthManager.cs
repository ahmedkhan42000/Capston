using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int Vaccination_Level;
    int startingHealth = 100;
    VirusDrop virusDropScript;
    public GameObject Indicator;

    private void Awake()
    {
        Vaccination_Level = startingHealth;
        virusDropScript = GetComponent<VirusDrop>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damageAmount)
    {
        Vaccination_Level -= damageAmount;
        if (Vaccination_Level <= 0)
        {
            virusDropScript.enabled = false;
            Debug.Log("==========VirusDrop SCRIPT is OFFF======");
            Indicator.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
        }
    }
}
