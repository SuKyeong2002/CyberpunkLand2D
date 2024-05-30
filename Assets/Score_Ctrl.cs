using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Ctrl : MonoBehaviour
{
    public int scoreNum = 0;
    public Text score;

    void Start()
    {
        
    }

    void Update()
    {
        score.text = scoreNum.ToString();
    }
}
