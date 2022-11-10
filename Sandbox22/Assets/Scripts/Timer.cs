using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float startTime = 60; //if float value is a decimal, it would need to be 60.5f
    [SerializeField]
    private TextMeshProUGUI timeText;

    private void Start()
    {
        StartCoroutine(CountdownTimer());
    }

    //coroutines are simpler to control while game is running, and sometimes more efficient
    IEnumerator CountdownTimer() //error message at first without a returning value
    {
        
        while (startTime > 0)
        {
           startTime -= Time.deltaTime;
           timeText.text = "Time: " + (int)startTime; //casting, changing float to int
            yield return null;
        }        

    }
}
