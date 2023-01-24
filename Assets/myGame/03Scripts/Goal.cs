using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject fischorange;
    public GameObject fischrosa;
    public GameObject fischblau;
    public GameObject fischgelb;

    public GameObject bubblesorange;
    public GameObject bubblesrosa;
    public GameObject bubblesblau;
    public GameObject bubblesgelb;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischorange)
        {
            Debug.Log("Goal");
            bubblesorange.SetActive(true);

        }

        if (other.gameObject == fischrosa)
        {
            Debug.Log("Goal");
            bubblesrosa.SetActive(true);
        }

        if (other.gameObject == fischblau)
        {
            Debug.Log("Goal");
            bubblesblau.SetActive(true);
        }

        if (other.gameObject == fischgelb)
        {
            Debug.Log("Goal");
            bubblesgelb.SetActive(true);
        }
    }


    }
