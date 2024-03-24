using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IntroManagerScript : MonoBehaviour
{
    public Animator cubeAnimator;
    public Animator cameraAnimator;
    
    void Start(){
        StartCoroutine(endIntro());

        
    }

    IEnumerator endIntro(){
        yield return new WaitForSeconds(12);
        cubeAnimator.enabled = false;
        cameraAnimator.enabled = false;
    }
    
}
