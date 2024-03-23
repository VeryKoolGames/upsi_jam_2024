using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

[Serializable]
public class KeyValuePairC {
    public int id;
    public AudioSource val;
}

public class FacesHandler : MonoBehaviour
{
    private Dictionary<int, GameObject> faceDict = new Dictionary<int, GameObject>();
    public GameObject[] faces;
    public bool isInFocusMode;

    void Start()
    {
        for (int i = 0; i < faces.Length; i++)
        {
            faceDict.Add(i, faces[i]);
        }
    }

    public void DeactivateOtherFaces(int id) {
        foreach(KeyValuePair<int, GameObject> entry in faceDict)
        {
            if (entry.Key != id){
                entry.Value.SetActive(false);
            }
            else if (entry.Key == id)
                entry.Value.SetActive(true);
        }
    }

    internal void DeactivateFaces()
    {
        foreach(KeyValuePair<int, GameObject> entry in faceDict)
        {
            entry.Value.SetActive(false);
        }
    }
    
    internal void ReactivateColliders()
    {
        foreach(KeyValuePair<int, GameObject> entry in faceDict)
        {
            entry.Value.GetComponentInParent<Collider>().enabled = true;
        }
    } 
    internal void DeactivateColliders()
    {
        foreach(KeyValuePair<int, GameObject> entry in faceDict)
        {
            entry.Value.GetComponentInParent<Collider>().enabled = false;
        }
    } 
}
