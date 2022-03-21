using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public GameObject Player;
    Vector3 Offset =new Vector3(0.380030394f, 5.72367907f, -8.17488384f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.position = Player.transform.position + Offset;
    }
}
