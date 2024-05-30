using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacial_Move : MonoBehaviour
{
    void Start()
    {
        // Destroy(gameObject, 2.0f);
    }

    void Update()
    {
        transform.Translate(-2*Time.deltaTime*10, -1*Time.deltaTime*10, 0);
    }
}
