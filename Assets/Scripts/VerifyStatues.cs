using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class VerifyStatues : MonoBehaviour
{
    [SerializeField] private Orientation[] correctOrientations;
    [SerializeField] private StatueRotationHandler[] statuesObject;
    [SerializeField] private GameObject _doorStatuesHandler;
    
    public void VerifyStatuesOrientation()
    {
        int correctCount = 0;
        for (int i = 0; i < statuesObject.Length; i++)
        {
            if (statuesObject[i].currentOrientation == correctOrientations[i])
            {
                correctCount++;
            }
        }

        if (correctCount == statuesObject.Length)
        {
            _doorStatuesHandler.GetComponent<Collider>().enabled = true;
        }
    }
}
