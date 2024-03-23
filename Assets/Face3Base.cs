using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face3Base : MonoBehaviour
{
    private int baseMatch = 0;

    private GameObject _constel;

    private void Start()
    {
        _constel = GameObject.FindGameObjectWithTag("Constel");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Star"))
        {
            Debug.Log("Star touches " + other.name);
            baseMatch = 1;
            _constel.GetComponent<Face3Constel>().checkTotalMatches();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Star"))
        {
            baseMatch = 0;
        }
    }

    public int getBaseMatch()
    {
        return baseMatch;
    }
}
