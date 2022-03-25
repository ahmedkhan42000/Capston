using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public GameObject Player;
    Vector3 Offset =new Vector3(-0.131711826f, 5.51103306f, -7.56623745f);
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = Player.transform.position + Offset;
    }
}
