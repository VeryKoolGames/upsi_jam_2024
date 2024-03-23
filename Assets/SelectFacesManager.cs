using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFacesManager : MonoBehaviour
{
    [SerializeField] private GameObject[] faceOneObjects;
    [SerializeField] private GameObject[] faceTwoObjects;
    [SerializeField] private GameObject[] faceThreeObjects;
    [SerializeField] private GameObject[] faceFourObjects;
    [SerializeField] private GameObject[] faceFiveObjects;
    [SerializeField] private GameObject[] faceSixObjects;
    private Dictionary<int, GameObject[]> facesObjectsDict = new Dictionary<int, GameObject[]>();
    
    // Start is called before the first frame update
    void Start()
    {
        facesObjectsDict.Add(0, faceOneObjects);
        facesObjectsDict.Add(1, faceTwoObjects);
        facesObjectsDict.Add(2, faceThreeObjects);
        facesObjectsDict.Add(3, faceFourObjects);
        facesObjectsDict.Add(4, faceFiveObjects);
        facesObjectsDict.Add(5, faceSixObjects);
    }

    public void ActivateFace(int faceId)
    {
        GameObject[] objects = facesObjectsDict[faceId];
        foreach (var obj in objects)
        {
            obj.GetComponent<Collider>().enabled = true;
        }
    }

    public void DeactivateFace(int faceId)
    {
        GameObject[] objects = facesObjectsDict[faceId];
        foreach (var obj in objects)
        {
            obj.GetComponent<Collider>().enabled = false;
        }
    }
}
