using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Practice : MonoBehaviour
{
    int Shoot_damage_Amount = 50;
    public GameObject ShootPoint;
    public GameObject ShootVirus_ParticleEffect;

    public delegate void UpdateScore_OnVirusHit_DL();
    public UpdateScore_OnVirusHit_DL updateScore_OnVirusHit_DL;


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
                    updateScore_OnVirusHit_DL?.Invoke();
                    Instantiate(ShootVirus_ParticleEffect, hitinfo.transform.position, hitinfo.transform.rotation);
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
