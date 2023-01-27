using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float ampli = 0.6f;
    public float f = 1.1f; 

    private Vector3 originalPos;

    void Start()
    {
        originalPos = transform.position;
    }

    void Update()
    {
        float y = ampli * Mathf.Sin(Time.time * f);
        transform.position = originalPos + new Vector3(0, y, 0);
    }
}