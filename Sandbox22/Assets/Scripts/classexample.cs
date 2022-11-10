using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classexample : MonoBehaviour
{
    public int wheels;
    public float speed;
    public float turnSpeed;

    public void Move()
    {
        Debug.Log("move forward");
    }
    //constructor, now all those variable values will be expected in a new instance
    public classexample(int _wheels, float _speed, float _turnSpeed)
    {
        wheels = _wheels;
        speed = _speed;
        turnSpeed = _turnSpeed;

    }
}
