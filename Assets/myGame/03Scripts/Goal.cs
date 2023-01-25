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

    public GameObject SonnenbrilleOrange;
    public GameObject SonnenbrilleRosa;
    public GameObject SonnenbrilleBlau;
    public GameObject SonnenbrilleGelb;

    public float speed = 0.01f;

    public bool dawosisOrange = true;
    public bool dawosisBlau = true;
    public bool dawosisRosa = true;
    public bool dawosisGelb = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischorange)
        {
            Debug.Log("Goal");
            bubblesorange.SetActive(true);
            SonnenbrilleOrange.SetActive(true);
            // transform.Rotate(Vector3.up * speed * Time.deltaTime);
            dawosisOrange = false;

        }

        if (other.gameObject == fischrosa)
        {
            Debug.Log("Goal");
            bubblesrosa.SetActive(true);
           // fischrosa.transform.position += new Vector3(3f, 0, 0);
            SonnenbrilleRosa.SetActive(true);
            dawosisRosa = false;

        }

        if (other.gameObject == fischblau)
        {
            Debug.Log("Goal");
            bubblesblau.SetActive(true);
         //   fischblau.transform.position += new Vector3(30f, 0, 0);
            SonnenbrilleBlau.SetActive(true);
            dawosisBlau = false;
        }

        if (other.gameObject == fischgelb)
        {
            Debug.Log("Goal");
            bubblesgelb.SetActive(true);
         //   fischgelb.transform.position += new Vector3(3f, 0, 0);
            SonnenbrilleGelb.SetActive(true);
            dawosisGelb = false;
        }
    }


    }
