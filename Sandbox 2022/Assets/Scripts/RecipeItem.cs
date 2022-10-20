using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeItem : MonoBehaviour
{
    [SerializeField]
    private int howLong;
    [SerializeField]
    private int howMuch;
    [SerializeField]
    private Vector3 startPosition;
    [SerializeField]
    private Vector3 endPosition;

    private void Start()
    {
        startPosition = transform.position;

    }

    private void OnMouseDown()
    {
        transform.position = endPosition;
    }


}
