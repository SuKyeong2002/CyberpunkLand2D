using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_Move : MonoBehaviour
{
    float moveLR;
    public GameObject motoBody;
    public GameObject motoLTire;
    public GameObject motoRTire;   

    public GameObject ui_MotoBody;
    public GameObject ui_MotoLTire;
    public GameObject ui_MotoRTire;

    public GameObject UI_Medicine;

    void Start()
    {
        ui_MotoBody.SetActive(false);
        ui_MotoLTire.SetActive(false);
        ui_MotoRTire.SetActive(false);
        UI_Medicine.SetActive(false);
    }

    void Update()
    {
       /* moveLR = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 5;
        transform.Translate(moveLR, 0, 0); */

        if(Input.GetKeyDown(KeyCode.W)){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5.0f), ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "MotoBody") {
            other.gameObject.SetActive(false);
            ui_MotoBody.SetActive(true);
        }
        if(other.gameObject.name == "MotoLTire") {
            other.gameObject.SetActive(false);
            ui_MotoLTire.SetActive(true);
        }
        if(other.gameObject.name == "MotoRTire") {
            other.gameObject.SetActive(false);
            ui_MotoRTire.SetActive(true);
        }
        if(other.gameObject.name == "Medicine") {
            other.gameObject.SetActive(false);
            UI_Medicine.SetActive(true);
        }
        if(other.gameObject.name == "Medicine2") {
            other.gameObject.SetActive(false);
            UI_Medicine.SetActive(true);
        }
    }
}
