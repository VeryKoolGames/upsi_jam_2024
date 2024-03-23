using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face2PHUpDown : MonoBehaviour
{
    public void OnMouseDown()
    {
        if (gameObject.CompareTag("PHUp"))
        {
            gameObject.GetComponentInParent<Face2LockerNumber>().numPlus();
            gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("HitUp!");
        }
        else if (gameObject.CompareTag("PHDown"))
        {
            gameObject.GetComponentInParent<Face2LockerNumber>().numMinus();
            gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("HitDown!");
        }
        
    }
}
