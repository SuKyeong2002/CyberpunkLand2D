using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacial_Spawn : MonoBehaviour
{
    public GameObject pfThunder;
    float x_pos;
    float y_pos;
    GameObject[] SpiderRobot;
    GameObject[] HulkRobot;
    GameObject UI_Medicine;
    GameObject UI_MotoBody;
    GameObject UI_MotoLTire;
    GameObject UI_MotoRTire;
    GameObject Player;

    void Start()
    {
        UI_Medicine = GameObject.Find("UI_Medicine");
        UI_MotoBody = GameObject.Find("UI_MotoBody");
        UI_MotoLTire = GameObject.Find("UI_MotoLTire");
        UI_MotoRTire = GameObject.Find("UI_MotoRTire");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (UI_Medicine.activeSelf == true)
            {
                for (int i = 0; i < 20; i++) {
                    x_pos = Random.Range(50, -50);
                    y_pos = Random.Range(-50, 50);
                    Instantiate(pfThunder, new Vector2(x_pos, y_pos), transform.rotation);
                }

                SpiderRobot = GameObject.FindGameObjectsWithTag("Spider");
                for (int i = 0; i < SpiderRobot.Length; i++)
                {
                    Destroy(SpiderRobot[i]);
                }

                HulkRobot = GameObject.FindGameObjectsWithTag("Hulk");
                for (int i = 0; i < HulkRobot.Length; i++)
                {
                    Destroy(HulkRobot[i]);
                }

                UI_Medicine.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.F2)) {
            if (UI_MotoBody.activeSelf == true && UI_MotoLTire.activeSelf == true && UI_MotoRTire.activeSelf == true) 
             {
                Player = GameObject.FindGameObjectWithTag("Player");
                x_pos = 7.5f;
                y_pos = 18.1f;
                Player.transform.position = new Vector2(x_pos, y_pos);

                UI_MotoBody.SetActive(false);
                UI_MotoLTire.SetActive(false);
                UI_MotoRTire.SetActive(false);
             }
        }
    }
}