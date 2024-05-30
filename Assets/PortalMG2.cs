using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMG2 : MonoBehaviour {

    public Transform exitPortal;
    GetKey portalKey;

    void Start() {
       portalKey = GameObject.Find ("GoldenKey").GetComponent<GetKey> ();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player" && portalKey.isGetKey == true) {
            other.transform.position = /* exitPortal.position + */ new Vector3 (19.5f, 15.5f, 0);
        }
    }
}