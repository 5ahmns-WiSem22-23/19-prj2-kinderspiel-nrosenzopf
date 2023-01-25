using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootManager : MonoBehaviour
{

    public GameObject fischorange;
    public GameObject fischrosa;
    public GameObject fischblau;
    public GameObject fischgelb;

    public int deactivatedGO = 0;
    public bool x = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischorange)
        {
            deactivatedGO++;
            fischorange.SetActive(false);
        }

        if (other.gameObject == fischrosa)
        {
            deactivatedGO++;
            fischrosa.SetActive(false);

        }

        if (other.gameObject == fischblau)
        {
            deactivatedGO++;
            fischblau.SetActive(false);
        }

        if (other.gameObject == fischgelb)
        {
            deactivatedGO++;
            fischgelb.SetActive(false);
        }





    //   if(other.gameObject == fischorange && other.gameObject == fischrosa || other.gameObject == fischorange && other.gameObject == fischblau || other.gameObject == fischorange &&  other.gameObject == fischgelb || other.gameObject == fischrosa && other.gameObject == fischblau || other.gameObject == fischrosa && other.gameObject == fischgelb)
     //   {
    //        Debug.Log("Zwei");
     //   } 
    }


    void Update()
    {
        
        if (deactivatedGO >= 2 && x)
        {
            Debug.Log("Zwei oder mehr Gameobjekte wurden deaktiviert.");
            x = false;
        }
    }
}