using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastOff : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
              Debug.Log("hit ground");

        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("in box");
    }

}
