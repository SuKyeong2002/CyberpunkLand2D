using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiderRobot_MoveA2 : MonoBehaviour
{
    float moveLR = 1.5f;
    int bullet = 0;
    Score_Ctrl score;
    public float hp = 1;

    void Start()
    {
        // Destroy(gameObject, 20.0f);
        score = GameObject.Find("Score").GetComponent<Score_Ctrl>();
    }

    void Update()
    {
        transform.Translate(-moveLR * Time.deltaTime, 0, 0);
        if (transform.position.x <= 8.0f)
        {
            transform.position = new Vector3(8.0f, -19.5f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (transform.position.x >= 17.0f)
        {
            transform.position = new Vector3(17.0f, -19.5f, 0);
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
