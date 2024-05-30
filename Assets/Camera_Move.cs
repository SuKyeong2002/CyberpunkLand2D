using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    public Transform player;
    Vector3 target;

    void Start()
    {

    }

    void Update()
    {
        target = new Vector3(player.position.x, player.position.y, this.transform.position.z);

        transform.position = Vector3.Lerp(transform.position, target, 0.02f);
    }
}
