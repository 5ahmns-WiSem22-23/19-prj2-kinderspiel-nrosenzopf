using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootManager : MonoBehaviour
{

    public GameObject fischorange;
    public GameObject fischrosa;
    public GameObject fischblau;
    public GameObject fischgelb;

    public float speed = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fischorange)
        {
            fischorange.SetActive(false);
          //  fischorange.transform.position += new Vector3(3f, 0, 0);
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }

        if (other.gameObject == fischrosa)
        {
            fischrosa.SetActive(false);
            fischrosa.transform.position += new Vector3(3f, 0, 0);
        }

        if (other.gameObject == fischblau)
        {
            fischblau.SetActive(false);
            fischblau.transform.position += new Vector3(30f, 0, 0);
        }

        if (other.gameObject == fischgelb)
        {
            fischgelb.SetActive(false);
            fischgelb.transform.position += new Vector3(3f, 0, 0);
        }
    }
}