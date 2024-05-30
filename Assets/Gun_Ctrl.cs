using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Ctrl : MonoBehaviour
{
    public GameObject pfBullet;
    public GameObject pfshootExplosion;
    public AudioSource shootSound;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pfBullet, transform.position, transform.rotation);
            Instantiate(pfshootExplosion, transform.position, transform.rotation);
            shootSound.Play();
        }
    }
}
