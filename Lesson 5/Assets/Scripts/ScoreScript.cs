using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI Score;
    int score = 0;

    void OnTriggerEnter (Collider other){
        if (other.gameObject.name == "Ball"){
            score++;
            Score.text = score.ToString();
        }
    }
}
