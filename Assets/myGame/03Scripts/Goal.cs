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

    public float speed = 0.01f;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischorange)
        {
            Debug.Log("Goal");
            bubblesorange.SetActive(true);
           fischorange.transform.position += new Vector3(3f, 0, 0);
           // transform.Rotate(Vector3.up * speed * Time.deltaTime);

        }

        if (other.gameObject == fischrosa)
        {
            Debug.Log("Goal");
            bubblesrosa.SetActive(true);
            fischrosa.transform.position += new Vector3(3f, 0, 0);
        }

        if (other.gameObject == fischblau)
        {
            Debug.Log("Goal");
            bubblesblau.SetActive(true);
            fischblau.transform.position += new Vector3(30f, 0, 0);
        }

        if (other.gameObject == fischgelb)
        {
            Debug.Log("Goal");
            bubblesgelb.SetActive(true);
            fischgelb.transform.position += new Vector3(3f, 0, 0);
        }
    }


    }
