using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    private int scoreValue = 0;
    [SerializeField]
    //TextMeshProUGUI is the actual text object, always a data and visual component
    private TextMeshProUGUI scoreText;

    //public so that unity events can call it
    public void UpdateScore(int value)
    {
        //in this way, the data is updated, not neccesarily increased
        scoreValue += value;
        scoreText.text = "Score: " + scoreValue; //concatenation, joining to data types into a string (?)
    }
}
