using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hulk_Ctrl : MonoBehaviour
{
    float currentTime = 0;
    float offsetTime = 3;
    public GameObject pfHulk;

    void Start()
    {
        Destroy(gameObject, 20.0f);
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > offsetTime) 
        {
            Instantiate(pfHulk, transform.position, transform.rotation);
            currentTime = 0;
        }
    }
}