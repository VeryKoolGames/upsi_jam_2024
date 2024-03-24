using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face3Constel : MonoBehaviour
{
    [SerializeField] private GameObject[] baseArray = new GameObject[20];
    [SerializeField] private GameObject F3G1slider; // https://www.youtube.com/watch?v=JS4k_lwmZHk
    private int nMatch = 0;
    private GameObject[] starsConstList;

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
        {
            Debug.Log("FACE 3 COMPLETED, CONGRATS 🎉");
            F3G1slider.GetComponent<Collider>().enabled = true;
            GetComponent<AudioSource>().Play();
            starsConstList = GameObject.FindGameObjectsWithTag("StarsConst");
            foreach (GameObject starsConst in starsConstList)
                starsConst.GetComponent<Collider>().enabled = false;
        }
    }
}
