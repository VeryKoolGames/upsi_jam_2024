using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face3Constel : MonoBehaviour
{
    [SerializeField] private GameObject[] baseArray = new GameObject[20];
    private int nMatch = 0;

    public void checkTotalMatches()
    {
        nMatch = 0;
        for (int i = 0; i < 20; i++)
        {
            //Debug.Log(transform.GetChild(i).name);
            //nMatch += transform.GetChild(i).GetComponentInChildren<Face3Base>().getBaseMatch();
            nMatch += baseArray[i].GetComponentInChildren<Face3Base>().getBaseMatch();
        }
        Debug.Log("Matches number = " + nMatch);
        if (nMatch == 20)
            Debug.Log("FACE 3 COMPLETED, CONGRATS 🎉");
    }
}
