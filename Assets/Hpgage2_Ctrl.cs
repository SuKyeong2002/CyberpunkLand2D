using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpgage2_Ctrl : MonoBehaviour
{
    public GameObject boss;
    public Image HpGage2;

    void Start()
    {
        
    }

    void Update()
    {
        if(boss != null) {
            HpGage2.fillAmount = boss.GetComponent<Boss_Move>().hp2 * 0.01f;
            if(HpGage2.fillAmount < 0.1f) {
                HpGage2.fillAmount = 0.01f;
            }
        }
    }
}
