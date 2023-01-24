using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject fischorange;
    public GameObject fischrosa;
    public GameObject fischblau;
    public GameObject fischgelb;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischorange)
        {
            Debug.Log("Goal");
        }

        if (other.gameObject == fischrosa)
        {
            Debug.Log("Goal");
        }

        if (other.gameObject == fischblau)
        {
            Debug.Log("Goal");
        }

        if (other.gameObject == fischgelb)
        {
            Debug.Log("Goal");
        }
    }


    }
