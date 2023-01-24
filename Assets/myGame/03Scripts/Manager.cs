using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] objects;
    private int currentObject = 0;

    public GameObject rot;
    public GameObject blau;
    public GameObject grün;
    public GameObject gelb;
    public GameObject rosa;
    public GameObject orange;

    public GameObject goal;


    public GameObject fischrosa;
    public GameObject fischgelb;
    public GameObject fischblau; 
    public GameObject fischorange;
    public GameObject boot;
    public bool x = false;

    public void NextObject()
    {
        currentObject = Random.Range(0, objects.Length);
        for (int i = 0; i < objects.Length; i++)
        {
            if (i == currentObject)
            {
                objects[i].SetActive(true);
                x = true;
            }
            else
            {
                objects[i].SetActive(false);
            }
        }
    }

    public void BlauWeiter()
    {
        Debug.Log("WTF");
        fischblau.transform.position += new Vector3(1.5f, 0,0);    
    }

    public void OrangeWeiter()
    {
        Debug.Log("WTF");
        fischorange.transform.position += new Vector3(1.5f, 0, 0);
    }

    public void RosaWeiter()
    {
        Debug.Log("WTF");
        fischrosa.transform.position += new Vector3(1.5f, 0, 0);
    }

    public void GelbWeiter()
    {
        Debug.Log("WTF");
        fischgelb.transform.position += new Vector3(1.5f, 0, 0);
    }

    public void BootGehtWeiter()
    {

        Debug.Log("Kak Boot");
        boot.transform.position += new Vector3(1.5f, 0, 0);

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == boot && gameObject == fischorange)
        {
            Debug.Log("Fix");
        }
    }



            void Update()
    {


        if (blau.activeSelf && x)
        {
            BlauWeiter();
            x = false;
        
        }

        if (rosa.activeSelf && x)
        {
            RosaWeiter();
            x = false;

        }


        if (gelb.activeSelf && x)
        {
            GelbWeiter();
            x = false;

        }


        if (orange.activeSelf && x)
        {
            OrangeWeiter();
            x = false;

        }

        if (rot.activeSelf && x)
        {
            BootGehtWeiter();
            x = false;

        }


        if (grün.activeSelf && x)
        {
            BootGehtWeiter();
            x = false;

        }
    }
}



