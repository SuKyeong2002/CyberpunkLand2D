using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GetKey : MonoBehaviour
{
    public bool isGetKey = false;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            GameObject.Find("ActiveKey").GetComponent<Image>().enabled = true;
            Destroy(gameObject);
            isGetKey = true;
        }
    }
}
