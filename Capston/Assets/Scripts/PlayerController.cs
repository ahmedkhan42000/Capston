using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera Cam;
    int playerMovementSpeed = 2;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        Movement(); 
    }
    private void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * playerMovementSpeed * Time.deltaTime);
            animator.SetFloat("Speed", 0.2f);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetFloat("Speed", 0f);
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * playerMovementSpeed * Time.deltaTime);
            animator.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("Run", false);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("Shoot",true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            animator.SetBool("Shoot", false);
        }

        //if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        //{
        //        transform.Translate(Vector3.back * playerMovementSpeed * Time.deltaTime);
        //}
        
        /***Player Rotaion Using Mouse Point***/
        Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(hit.point);
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
        }
    }

}
