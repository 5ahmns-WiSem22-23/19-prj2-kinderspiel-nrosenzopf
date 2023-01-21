using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] objects;
    private int currentObject = 0;

    public void NextObject()
    {
        currentObject = Random.Range(0, objects.Length);
        for (int i = 0; i < objects.Length; i++)
        {
            if (i == currentObject)
            {
                objects[i].SetActive(true);
            }
            else
            {
                objects[i].SetActive(false);
            }
        }
    }
}



