using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianPatrol : MonoBehaviour
{

    public Transform[] moveSpots;
    float speed = 3;
    int MoveSpotIndex;
    float dist;
    private void Start()
    {
        MoveSpotIndex = 0;
        transform.LookAt(moveSpots[MoveSpotIndex].position);
    }

    private void Update()
    {
        Patrol();
    }
    void Patrol()
    {
        dist = Vector3.Distance(transform.position, moveSpots[MoveSpotIndex].position);
        if (dist < 1f)
        {
            MoveSpotIndex++;
            if (MoveSpotIndex >= moveSpots.Length)
            {
                MoveSpotIndex = 0;
            }
            transform.LookAt(moveSpots[MoveSpotIndex].position);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

