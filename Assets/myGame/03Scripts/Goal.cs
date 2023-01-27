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

    public bool goalBlau = false;
    public bool goalGelb = false;
    public bool goalRosa = false;
    public bool goalOrange = false;

    public int inGoal = 0;

    public ButtonManager buttonManagerScript;
    public GameObject panelFischWin;
    public GameObject panelAnglerLost;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischorange)
        {
            Debug.Log("Goal");
            bubblesorange.SetActive(true);
            SonnenbrilleOrange.SetActive(true);
            // transform.Rotate(Vector3.up * speed * Time.deltaTime);
            dawosisOrange = false;
            goalOrange = true;
            inGoal++;
        }

        if (other.gameObject == fischrosa)
        {
            Debug.Log("Goal");
            bubblesrosa.SetActive(true);
            // fischrosa.transform.position += new Vector3(3f, 0, 0);
            SonnenbrilleRosa.SetActive(true);
            dawosisRosa = false;
            goalRosa = true;
            inGoal++;
        }

        if (other.gameObject == fischblau)
        {
            Debug.Log("Goal");
            bubblesblau.SetActive(true);
            //   fischblau.transform.position += new Vector3(30f, 0, 0);
            SonnenbrilleBlau.SetActive(true);
            dawosisBlau = false;
            goalBlau = true;
            inGoal++;
        }

        if (other.gameObject == fischgelb)
        {
            Debug.Log("Goal");
            bubblesgelb.SetActive(true);
            //   fischgelb.transform.position += new Vector3(3f, 0, 0);
            SonnenbrilleGelb.SetActive(true);
            dawosisGelb = false;
            goalGelb = true;
            inGoal++;
        }
    }
    void Update()
    {

        if (inGoal > 2)
        {
            Debug.Log("Zwei oder mehr Fische im Ziel");
            if (buttonManagerScript.FischeTeam)
            { panelFischWin.SetActive(true); }

            if (buttonManagerScript.FischerTeam)
            {
                panelAnglerLost.SetActive(true);
            }

        }


    }
}
