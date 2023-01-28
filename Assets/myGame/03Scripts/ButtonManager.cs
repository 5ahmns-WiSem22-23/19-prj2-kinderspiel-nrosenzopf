using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonManager : MonoBehaviour
{
    public GameObject fischrosa;
    public GameObject fischgelb;
    public GameObject fischblau;
    public GameObject fischorange;


    public GameObject buttonBlau;
    public GameObject buttonGelb;
    public GameObject buttonOrange;
    public GameObject buttonRosa;

    public GameObject panel;
    public GameObject anfangpanel;

    public GameObject buttonFischerTeam;
    public GameObject buttonFischeTeam;

    public bool FischerTeam = false;
    public bool FischeTeam = false;


    public AudioSource audioSource;
    public AudioClip sound;
  

    public void AnglerTeam()
    {
        FischerTeam = true;
        buttonFischerTeam.SetActive(false);
        buttonFischeTeam.SetActive(false);
        anfangpanel.SetActive(false);
    }


    public void FischeeeTeam()
    {
        FischeTeam = true;
        buttonFischerTeam.SetActive(false);
        buttonFischeTeam.SetActive(false);
        anfangpanel.SetActive(false);
    }

    public void einsNachVorneBlau ()
    {
        fischblau.transform.position += new Vector3(1.5f, 0, 0);
        buttonBlau.SetActive(false);
        buttonGelb.SetActive(false);
        buttonOrange.SetActive(false);
        buttonRosa.SetActive(false);
        panel.SetActive(false);
    }

    public void einsNachVorneGelb()
    {
        fischgelb.transform.position += new Vector3(1.5f, 0, 0);
        buttonBlau.SetActive(false);
        buttonGelb.SetActive(false);
        buttonOrange.SetActive(false);
        buttonRosa.SetActive(false);
        panel.SetActive(false);
    }

    public void einsNachVorneOrange()
    {
        fischorange.transform.position += new Vector3(1.5f, 0, 0);
        buttonBlau.SetActive(false);
        buttonGelb.SetActive(false);
        buttonOrange.SetActive(false);
        buttonRosa.SetActive(false);
        panel.SetActive(false);
    }

    public void einsNachVorneRosa()
    {
        fischrosa.transform.position += new Vector3(1.5f, 0, 0);
        buttonBlau.SetActive(false);
        buttonGelb.SetActive(false);
        buttonOrange.SetActive(false);
        buttonRosa.SetActive(false);
        panel.SetActive(false);
    }


 
    public void PlaySound()
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}



