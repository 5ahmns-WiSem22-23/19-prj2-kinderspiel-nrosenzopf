using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootManager : MonoBehaviour
{

    public GameObject fischorange;
    public GameObject fischrosa;
    public GameObject fischblau;
    public GameObject fischgelb;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischorange)
        {
            fischorange.SetActive(false);
        }

        if (other.gameObject == fischrosa)
        {
           fischrosa.SetActive(false);

        }

        if (other.gameObject == fischblau)
        {
            fischblau.SetActive(false);
        }

        if (other.gameObject == fischgelb)
        {
            fischgelb.SetActive(false);
        }


    //   if(other.gameObject == fischorange && other.gameObject == fischrosa || other.gameObject == fischorange && other.gameObject == fischblau || other.gameObject == fischorange &&  other.gameObject == fischgelb || other.gameObject == fischrosa && other.gameObject == fischblau || other.gameObject == fischrosa && other.gameObject == fischgelb)
     //   {
    //        Debug.Log("Zwei");
     //   } 
    }
}