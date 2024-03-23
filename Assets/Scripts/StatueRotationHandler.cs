using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class StatueRotationHandler : MonoBehaviour
{
    [SerializeField] private Animator statueAnimator;
    [SerializeField] private VerifyStatues _verifyStatues;
    public Orientation currentOrientation;
    [SerializeField] private Orientation startOrientation;

    private void Start()
    {
        currentOrientation = startOrientation;
    }

    private void OnMouseDown()
    {
        StartCoroutine(rotateStatue());
    }

    IEnumerator rotateStatue()
    {
        statueAnimator.SetBool("rotateBool", value:true);
        yield return new WaitForSeconds(1.5f);
        statueAnimator.SetBool("rotateBool", value:false);
        currentOrientation++;
        if (currentOrientation > Orientation.SOUTH)
        {
            currentOrientation = Orientation.EAST;
        }
        _verifyStatues.VerifyStatuesOrientation();
    }
    
}
