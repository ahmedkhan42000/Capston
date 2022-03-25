using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToRoom : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RoomDoor")
        {
            Debug.Log( gameObject.name +"Collided with" + collision.gameObject.name);
            animator.SetInteger("Win",1);
            Destroy(gameObject,3);
        }
    }

}
