using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Move : MonoBehaviour
{
    public Rigidbody2D rigid;
    public GameObject pfHulkExplosion;
    public float hp = 1;
    
    void Start()
    {
        rigid.AddForce(transform.right * 5000 * Time.deltaTime, ForceMode2D.Impulse);
        Destroy(gameObject, 5.0f);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Hulk")
        {
            hp = hp + 20;
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(pfHulkExplosion, transform.position, transform.rotation);
        }
        if (other.gameObject.tag == "Spider")
        {
            hp = hp + 20;
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(pfHulkExplosion, transform.position, transform.rotation);
        }
    }
}
