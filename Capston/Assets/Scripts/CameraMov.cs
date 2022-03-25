using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public GameObject Player;
    //public Vector3 Offset;
    Vector3 Offset =new Vector3(0f, 9f, -14);
    public float SmoothTime = 0.125f;

    void Start()
    {
        
    }
    //void FixedUpdate()
    //{
    //    Vector3 desiredPosition = Player.transform.position + Offset;
    //    Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothTime * Time.deltaTime);
    //    transform.position = smoothedPosition;
    //}
    private void LateUpdate()
    {
        transform.position = Player.transform.position + Offset;
    }
}
