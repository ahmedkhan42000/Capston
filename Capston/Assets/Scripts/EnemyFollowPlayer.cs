using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollowPlayer : MonoBehaviour
{
    public Transform Target;
    float speed = 4f;
    Rigidbody rigidbody;
    Vector3 offset =new Vector3 (1,0,0);

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        MovesTowardTarget();
    }
    void MovesTowardTarget()
    {
        Vector3 Pos = Vector3.MoveTowards(transform.position, Target.position + offset, speed * Time.deltaTime);
        rigidbody.MovePosition(Pos);
        transform.LookAt(Target);
    }
}