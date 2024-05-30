using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderRobot_Ctrl : MonoBehaviour
{
    float currentTime = 0;
    float offsetTime = 4;
    public GameObject pfSpiderRobot;

    void Start()
    {
        Destroy(gameObject, 20.0f);
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > offsetTime) 
        {
            Instantiate(pfSpiderRobot, transform.position, transform.rotation);
            currentTime = 0;
        }
    }
}
