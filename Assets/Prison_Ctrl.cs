using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prison_Ctrl : MonoBehaviour
{
    public bool isCollision = false;
    public GameObject Player;

    void Start()
    {

    }

    void Update()
    {
        if (isCollision == true && Player.GetComponent<player_Move>().getKey == true) 
        {
            transform.Translate(0, 0.001f, 0);
            if (transform.position.y >= 19)
            {
                transform.position = new Vector3(9.0f, 19.0f, 0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("플레이어랑 충돌했다");
            isCollision = true;
        }
    }
}
