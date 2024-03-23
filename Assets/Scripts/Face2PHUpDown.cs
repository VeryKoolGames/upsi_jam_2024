using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face2PHUpDown : MonoBehaviour
{
    public void OnMouseUp()
    {
        if (gameObject.CompareTag("PHUp"))
        {
            gameObject.GetComponentInParent<Face2LockerNumber>().numPlus();
            Debug.Log("HitUp!");
        }
        else if (gameObject.CompareTag("PHDown"))
        {
            gameObject.GetComponentInParent<Face2LockerNumber>().numMinus();
            Debug.Log("HitDown!");
        }
        
    }
}
