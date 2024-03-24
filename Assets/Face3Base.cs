using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Face3Base : MonoBehaviour
{
    [SerializeField] private Material goldMat;
    [SerializeField] private Material greyMat;
    private int baseMatch = 0;
    private string currentLink;
    private GameObject _constel;

    private void Start()
    {
        _constel = GameObject.FindGameObjectWithTag("Constel");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (baseMatch == 1) return;
        if (other.CompareTag("Star"))
        {
            currentLink = other.name;
            Debug.Log("Star touches " + currentLink);
            baseMatch = 1;
            transform.GetComponent<MeshRenderer>().material = goldMat;
            _constel.GetComponent<Face3Constel>().checkTotalMatches();
            GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == currentLink)
        {
            Debug.Log("Star leaves " + currentLink);
            transform.GetComponent<MeshRenderer>().material = greyMat;
            baseMatch = 0;
        }
    }

    public int getBaseMatch()
    {
        return baseMatch;
    }
}
