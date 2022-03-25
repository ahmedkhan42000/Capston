using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Practice : MonoBehaviour
{
    int Shoot_damage_Amount = 10;
    public GameObject ShootPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot(); //Killing Virus ON Collision with ray
    }
    void Shoot()
    {
        if (Input.GetButton("Fire1"))
        {
            Debug.DrawRay(ShootPoint.transform.position, ShootPoint.transform.forward * 100, Color.red, 1);
            Ray ray = new Ray(ShootPoint.transform.position, ShootPoint.transform.forward);
            RaycastHit hitinfo;
            if (Physics.Raycast(ray, out hitinfo, 100))
            {
                Debug.Log(hitinfo.transform.name);
                if (hitinfo.transform.tag == "Virus")
                {
                    Destroy(hitinfo.collider.gameObject);
                }
                if (hitinfo.transform.tag == "Civilian" && hitinfo.transform.GetComponent<VirusDrop>().isActiveAndEnabled)
                {
                    var health = hitinfo.collider.GetComponent<HealthManager>();
                    health.TakeDamage(Shoot_damage_Amount);
                }
            }
        }
    }
}
