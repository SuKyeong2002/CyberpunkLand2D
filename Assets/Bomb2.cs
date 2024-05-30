using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb2 : MonoBehaviour
{
    Transform player;

    void Start()
    {
        GameObject playerObject = GameObject.Find("Player");
        if (playerObject != null)
        {
            player = playerObject.GetComponent<Transform>();
        }
    }

    void Update()
    {
        // player가 null인지 확인
        if (player == null)
        {
            return;
        }

        Vector3 distance = transform.position - player.position;
        float d = distance.magnitude; 
        float limit = 3.0f;
        if (d <= limit) {
            GetComponent<Animator>().SetBool("isGrow", true);
        }  else {
            GetComponent<Animator>().SetBool("isGrow", false);
        }
    }
}
