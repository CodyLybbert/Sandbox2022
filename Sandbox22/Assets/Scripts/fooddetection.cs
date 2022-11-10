using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class fooddetection : MonoBehaviour
{
    public UnityEvent foodEvent;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            foodEvent.Invoke();
        }
    }
}
