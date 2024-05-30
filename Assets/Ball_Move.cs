using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{
    public Rigidbody2D rigid;

    void Start()
    {
        rigid.AddForce(-transform.right * 950 * Time.deltaTime, ForceMode2D.Impulse);
        Destroy(gameObject, 5.0f);
    }

    void Update()
    {
        
    }
}
