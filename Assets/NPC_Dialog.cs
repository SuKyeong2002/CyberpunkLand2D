using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialog : MonoBehaviour
{
    public GameObject aPoint;
    public GameObject bPoint;
    public GameObject dialog;
    float ab_Distance;

    void Start()
    {
        
    }

    void Update()
    {
        ab_Distance = Vector3.Distance (aPoint.transform.position, bPoint.transform.position);
        if(ab_Distance < 2.0f) {
            dialog.SetActive (true);
        } else {
            dialog.SetActive (false);
        }
    }
}
