using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera Cam;
    float playerMovementSpeed = 0.5f;
    float playerFastMovementSpeed = 1f;
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
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * playerMovementSpeed * Time.deltaTime);
            animator.SetFloat("Speed", 0.2f);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            animator.SetFloat("Speed", 0f);
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * playerFastMovementSpeed * Time.deltaTime);
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
