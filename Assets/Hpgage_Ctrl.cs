using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpgage_Ctrl : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public Image HpGage;

    void Start()
    {
        
    }

    void Update()
    {
        HpGage.fillAmount = player.GetComponent<player_Move>().hp;
    }
}
