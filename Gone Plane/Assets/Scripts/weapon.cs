using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletprefab;
    public AudioClip audClip;
    public AudioSource Auds;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }        
    }

    public void Shoot()
    {
        Auds.PlayOneShot(audClip);
        Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
    }
}
