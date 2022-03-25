using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBringEnemy : MonoBehaviour
{
    ConvertToEnemy convToEnScript;
    EnemyFollowPlayer enemyAiScript;
    CivilianPatrol civPatScript;
    CivilianAnimControl civAnimConScript;

    Animator animator;
    void Start()
    {
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Enemy follows player Code
        enemyAiScript = collision.gameObject.GetComponent<EnemyFollowPlayer>();
        convToEnScript = collision.gameObject.GetComponent<ConvertToEnemy>();
        civPatScript = collision.gameObject.GetComponent<CivilianPatrol>();
        civAnimConScript = collision.gameObject.GetComponent<CivilianAnimControl>();
        if (collision.gameObject.tag == "Civilian" && convToEnScript.Infected == false)
        {
            enemyAiScript.enabled = true;
            civPatScript.enabled = false;
            convToEnScript.enabled = false;
            civAnimConScript.enabled = true;
            Debug.Log("Enemy Movinging With Player");
        }
    }
}
