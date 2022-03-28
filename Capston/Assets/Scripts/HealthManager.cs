using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int Vaccination_Level;
    int startingHealth = 100;
    VirusDrop virusDropScript;
    ConvertToEnemy convertToEnemyScript;
    public GameObject Indicator;

    public delegate void UpdateScore_OnCivHit_DL();
    public UpdateScore_OnCivHit_DL updateScore_OnCivHit_DL;

    private void Awake()
    {
        Vaccination_Level = startingHealth;
        virusDropScript = GetComponent<VirusDrop>();
        convertToEnemyScript = GetComponent<ConvertToEnemy>();
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
            convertToEnemyScript.Infected = false;
            Debug.Log("==========VirusDrop SCRIPT is OFFF======");
            Indicator.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
            updateScore_OnCivHit_DL?.Invoke();
        }
    }
}
