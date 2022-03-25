using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianAnimControl : MonoBehaviour
{
    public GameObject Indicator;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        CivilianAnimControlor(); 
    }
    void CivilianAnimControlor()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetInteger("Speed", 1);
        }
        else
        {
            animator.SetInteger("Speed", 0);
        }
        Indicator.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.yellow);
    }
}
