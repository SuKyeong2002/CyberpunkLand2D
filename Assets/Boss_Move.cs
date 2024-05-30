using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss_Move : MonoBehaviour
{
    float moveLR = 1.5f;
    public int hp2 = 100;
    public GameObject pfHulkExplosion;
    int bullet = 0;
    Score_Ctrl score;
    
    void Start()
    {
        // Destroy(gameObject, 20.0f);
        score = GameObject.Find("Score").GetComponent<Score_Ctrl>();   
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Bullet")
        {
            hp2 = hp2 - 10;

            bullet = bullet + 1;
            if (bullet == 10) {
                score.scoreNum += 50;
                Destroy(gameObject);
                Instantiate(pfHulkExplosion, transform.position, transform.rotation);
            }
        }
    }

    void Update()
    {

        transform.Translate(-moveLR * Time.deltaTime, 0, 0);
        if (transform.position.x  <= -10.0f) {
            transform.position = new Vector3(-10.0f, 15.2f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        } else if (transform.position.x >= -6.0f) {
            transform.position = new Vector3(-6.0f, 15.2f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}