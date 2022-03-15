using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera Cam;
    int playerMovementSpeed = 5;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }
    void Update()
    {
        Movement();
        
    }
    private void Movement()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            //if (transform.position.x < 4)
            //{
                transform.Translate(Vector3.back * playerMovementSpeed * Time.deltaTime);

            //}
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //if (transform.position.x < 4)
            //{
                transform.Translate(Vector3.forward * playerMovementSpeed * Time.deltaTime);
            //}
        }

        //PlayerRotation

        Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(hit.point);
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
        }
    }

}
