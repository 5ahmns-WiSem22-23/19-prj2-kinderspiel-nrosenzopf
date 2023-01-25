using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] objects;
    private int currentObject = 0;

    public GameObject rot;
    public GameObject blau;
    public GameObject gr�n;
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

    public Goal goalScript;
    public BootManager bootScript;

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

        if (blau.activeSelf && goalScript.goalBlau && x)
        {
            Debug.Log("Hier kommen die Buttons");
            x = false;

            if (goalScript.goalOrange == false && bootScript.fischorangeboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonOrange");
            }

            if (goalScript.goalGelb == false && bootScript.fischgelbboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonGelb");
            }

            if (goalScript.goalRosa == false && bootScript.fischrosaboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonRosa");
            }


        }




        if (gelb.activeSelf && goalScript.goalGelb && x)
        {
            Debug.Log("Hier kommen die Buttons");
            x = false;

            if (goalScript.goalOrange == false && bootScript.fischorangeboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonOrange");

            }

            if (goalScript.goalRosa == false && bootScript.fischrosaboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonRosa");
            }

            if (goalScript.goalBlau == false && bootScript.fischblauboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonBlau");
            }

        }





            if (rosa.activeSelf && goalScript.goalRosa && x)
        {
            Debug.Log("Hier kommen Buuuuuuuuuuuuttons");
            x = false;

            if (goalScript.goalOrange == false && bootScript.fischorangeboot.activeSelf == false) { 
            Debug.Log("Hier kommt ButtonOrange");     
            }

            if (goalScript.goalBlau == false && bootScript.fischblauboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonBlau");
            }

            if (goalScript.goalGelb == false && bootScript.fischgelbboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonGelb");
            }


        }




        if (orange.activeSelf && goalScript.goalOrange && x)
        {
            Debug.Log("Hier kommen die Buttons");
            x = false;

            if (goalScript.goalBlau == false && bootScript.fischblauboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonBlau");
            }

            if (goalScript.goalGelb == false && bootScript.fischgelbboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonGelb");
            }


            if (goalScript.goalGelb == false && bootScript.fischgelbboot.activeSelf == false)
            {
                Debug.Log("Hier kommt ButtonGelb");
            }

        }





            if (fischblau.activeSelf == false && x)
        {
             BootGehtWeiter();
            x = false;
        }

        if (fischrosa.activeSelf == false && x)
        {
            BootGehtWeiter();
            x = false;
        }

        if (fischgelb.activeSelf == false && x)
        {
            BootGehtWeiter();
            x = false;
        }

        if (fischorange.activeSelf == false && x)
        {
            BootGehtWeiter();
            x = false;
        }

        if (blau.activeSelf && x && goalScript.dawosisBlau)
        {
            BlauWeiter();
            x = false;
        
        }

        if (rosa.activeSelf && x && goalScript.dawosisRosa)
        {
            RosaWeiter();
            x = false;

        }


        if (gelb.activeSelf && x && goalScript.dawosisGelb)
        {
            GelbWeiter();
            x = false;

        }


        if (orange.activeSelf && x && goalScript.dawosisOrange)
        {
            OrangeWeiter();
            x = false;

        }

        if (rot.activeSelf && x)
        {
            BootGehtWeiter();
            x = false;

        }


        if (gr�n.activeSelf && x)
        {
            BootGehtWeiter();
            x = false;

        }
    }
}



