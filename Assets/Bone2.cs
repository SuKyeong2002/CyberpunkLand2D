using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone2 : MonoBehaviour
{
    Transform player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 distance = transform.position - player.position;
        float d = distance.magnitude; 
        float limit = 3.0f;
        if (d <= limit) {
            GetComponent<Animator>().SetBool("isGrow2", true);
        }  else {
            GetComponent<Animator>().SetBool("isGrow2", false);
        }
    }
}
