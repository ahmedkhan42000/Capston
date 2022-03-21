using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianAnimControl : MonoBehaviour
{
    Vector3 lastPos;
    Rigidbody rigidbody;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //CheckMovement();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetInteger("Speed", 1);
        }
        else
        {
            animator.SetInteger("Speed", 0);
        }
        
    }
    void CheckMovement()
    {
        if (rigidbody.velocity.magnitude > 0) //Make This a small number
        {
            //Debug.Log("Player has moved");
            Debug.Log(rigidbody.velocity.magnitude);
        }
    }
}
