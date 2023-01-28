using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootManager : MonoBehaviour
{

    public GameObject fischorange;
    public GameObject fischrosa;
    public GameObject fischblau;
    public GameObject fischgelb;
  

    public GameObject fischorangeboot;
    public GameObject fischrosaboot;
    public GameObject fischblauboot;
    public GameObject fischgelbboot;

    public GameObject panelFischerwin;
    public GameObject panelFischelost;
    public ButtonManager buttonManagerScript;

    public int deactivatedGO = 0;
    public bool x = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischorange)
        {
            deactivatedGO++;
            fischorange.SetActive(false);
            fischorangeboot.SetActive(true);
        }

        if (other.gameObject == fischrosa)
        {
            deactivatedGO++;
            fischrosa.SetActive(false);
            fischrosaboot.SetActive(true);
        }

        if (other.gameObject == fischblau)
        {
            deactivatedGO++;
            fischblau.SetActive(false);
            fischblauboot.SetActive(true);
        }

        if (other.gameObject == fischgelb)
        {
            deactivatedGO++;
            fischgelb.SetActive(false);
            fischgelbboot.SetActive(true);
        }


    }


    void Update()
    {
        
        if (deactivatedGO > 2 && x)
        {
            Debug.Log("Zwei oder mehr Gameobjekte wurden deaktiviert.");
            x = false;
            if (buttonManagerScript.FischerTeam)
            {
                panelFischerwin.SetActive(true);
            }

            if (buttonManagerScript.FischeTeam)
            {
                panelFischelost.SetActive(true);
            }
        }
    }
}