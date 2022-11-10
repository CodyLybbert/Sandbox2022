using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float rayDistance = 10;
    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.forward * rayDistance, Color.green);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, rayDistance, LayerMask.GetMask("Water")))
        {
            Debug.Log("hit");
        }
    }
}
