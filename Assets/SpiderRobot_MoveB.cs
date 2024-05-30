using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderRobot_MoveB : MonoBehaviour
{
    float moveLR = 2.0f;
    int bullet = 0;
    Score_Ctrl score;

    void Start()
    {
        // Destroy(gameObject, 20.0f);
        score = GameObject.Find("Score").GetComponent<Score_Ctrl>();
    }

    void Update()
    {
        transform.Translate(-moveLR * Time.deltaTime, 0, 0);
        if (transform.position.x  <= -9.5f) {
            transform.position = new Vector3(-9.5f, -12.5f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        } else if (transform.position.x >= 10.0f) {
            transform.position = new Vector3(10.0f, -12.5f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Bullet") {
            bullet = bullet + 1;
            if (bullet == 1) {
                score.scoreNum += 10;
                Destroy(gameObject);
            }
        }
    }
}
