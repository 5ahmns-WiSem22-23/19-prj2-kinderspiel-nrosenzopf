using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    void Start()
    {
        Invoke("DeactivateGameObject", 2.5f);
    }

    void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }
}